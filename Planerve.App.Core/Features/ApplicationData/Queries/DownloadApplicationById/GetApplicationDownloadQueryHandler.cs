using AutoMapper;
using Kevsoft.PDFtk;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Planerve.App.Core.Contracts.Authorization;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Queries.DownloadApplicationById;

public class GetApplicationDownloadQueryHandler : IRequestHandler<GetApplicationDownloadQuery, DownloadExportFileVm>
{
    private readonly IAsyncRepository<Application> _repository;
    private readonly IPDFtk _pdFtk;
    private readonly IMapper _mapper;
    private readonly ILoggedInUserService _loggedInUserService;
    private readonly IAuthorizationService _authorizationService;

    public GetApplicationDownloadQueryHandler(IPDFtk pdFtk, IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IAuthorizationService authorizationService)
    {
        _pdFtk = pdFtk;
        _mapper = mapper;
        _repository = repository;
        _loggedInUserService = loggedInUserService;
        _authorizationService = authorizationService;
    }

    public async Task<DownloadExportFileVm> Handle(GetApplicationDownloadQuery request, CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var userId = await _loggedInUserService.UserId();
        var user = await _loggedInUserService.GetUser();

        // Get application by id and check that current user is the owner.
        var specification = new GetApplicationByIdSpecification(request.Id, userId);

        var applicationEntity = _repository.FindWithSpecificationPattern(specification);

        if (!applicationEntity.Any())
        {
            throw new NotFoundException(nameof(Application), request.Id);
        }

        var selectedApplication = applicationEntity.First();

        var result = await _authorizationService.AuthorizeAsync(user, selectedApplication, ApplicationPolicies.ReadApplication.Requirements);

        if (!result.Succeeded)
        {
            throw new NotAuthorisedException(nameof(Application), userId);
        }

        if (selectedApplication.FormData is null)
        {
            throw new NotFoundException("This application has no form data", request.Id);
        }

        var download = await GenerateDownload(selectedApplication, cancellationToken);

        var applicationExportFileDto = new DownloadExportFileVm() { ContentType = "application/pdf", Data = download, ApplicationExportFileName = $"{Guid.NewGuid()}.pdf" };

        return applicationExportFileDto;
    }

    private async Task<IPDFtkResult<byte[]>> GenerateDownload(Application model, CancellationToken cancellationToken)
    {
        switch (model.ApplicationType)
        {
            case 1:
                var templateDictionary = new Dictionary<string, string>()
                {
                    ["1Text1"] = model.FormData.FormTypeOneData.OneTextOne,
                    ["1Text2"] = model.FormData.FormTypeOneData.OneTextTwo,
                    ["1Text3"] = model.FormData.FormTypeOneData.OneTextThree,
                    ["1Text4"] = model.FormData.FormTypeOneData.OneTextFour,
                    ["1Text5"] = model.FormData.FormTypeOneData.OneTextFive,
                    ["1Text6"] = model.FormData.FormTypeOneData.OneTextSix,
                    ["1Text7"] = model.FormData.FormTypeOneData.OneTextSeven,
                    ["1Text8"] = model.FormData.FormTypeOneData.OneTextEight,
                    ["1Text9"] = model.FormData.FormTypeOneData.OneTextNine,
                    ["1Text10"] = model.FormData.FormTypeOneData.OneTextTen,
                    ["1Text11"] = model.FormData.FormTypeOneData.OneTextEleven,
                    ["1Text12"] = model.FormData.FormTypeOneData.OneTextTwelve,
                    ["1Text13"] = model.FormData.FormTypeOneData.OneTextThirteen,
                    ["1Text14"] = model.FormData.FormTypeOneData.OneTextFourteen,
                    ["1Text15"] = model.FormData.FormTypeOneData.OneTextFithteen,

                    ["2Text1"] = model.FormData.FormTypeOneData.TwoTextOne,
                    ["2Text2"] = model.FormData.FormTypeOneData.TwoTextTwo,
                    ["2Text3"] = model.FormData.FormTypeOneData.TwoTextThree,
                    ["2Text4"] = model.FormData.FormTypeOneData.TwoTextFour,
                    ["2Text5"] = model.FormData.FormTypeOneData.TwoTextFive,
                    ["2Text6"] = model.FormData.FormTypeOneData.TwoTextSix,
                    ["2Text7"] = model.FormData.FormTypeOneData.TwoTextSeven,
                    ["2Text8"] = model.FormData.FormTypeOneData.TwoTextEight,
                    ["2Text9"] = model.FormData.FormTypeOneData.TwoTextNine,
                    ["2Text10"] = model.FormData.FormTypeOneData.TwoTextTen,
                    ["2Text11"] = model.FormData.FormTypeOneData.TwoTextEleven,
                    ["2Text12"] = model.FormData.FormTypeOneData.TwoTextTwelve,
                    ["2Text13"] = model.FormData.FormTypeOneData.TwoTextThirteen,
                    ["2Text14"] = model.FormData.FormTypeOneData.TwoTextFourteen,
                    ["2Text15"] = model.FormData.FormTypeOneData.TwoTextFithteen,
                };
                var pdfFile = await File.ReadAllBytesAsync("FormTemplates/ApplicationTypeOne.pdf", cancellationToken);

                var fillFormAsync = await _pdFtk.FillFormAsync(pdfFile, templateDictionary, false, false);

                if (!fillFormAsync.Success)
                    throw new Exception($"Oops: {fillFormAsync.StandardError}");

                return fillFormAsync;
        }
        return null;
    }
}