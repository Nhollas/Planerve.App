using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using AutoMapper;
using Kevsoft.PDFtk;
using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Queries.DownloadApplicationById;

public class GetApplicationDownloadQueryHandler : IRequestHandler<GetApplicationDownloadQuery, DownloadExportFileVm>
{
    private readonly IApplicationDataRepository _applicationDataRepository;
    private readonly IPDFtk _pdFtk;
    private readonly IMapper _mapper;

    public GetApplicationDownloadQueryHandler(IPDFtk pdFtk, IMapper mapper, IApplicationDataRepository appDataRepository)
    {
        _pdFtk = pdFtk;
        _mapper = mapper;
        _applicationDataRepository = appDataRepository;

    }

    public async Task<DownloadExportFileVm> Handle(GetApplicationDownloadQuery request, CancellationToken cancellationToken)
    {
        var application = await _applicationDataRepository.GetApplicationById(request.Id);

        if (application == null)
        {
            throw new NotFoundException(nameof(Application), request.Id);
        }

        var download = await GenerateDownload(application, cancellationToken);
        
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
                    ["1Text1"] = model.ApplicationTypeOne.OneTextOne,
                    ["1Text2"] = model.ApplicationTypeOne.OneTextTwo,
                    ["1Text3"] = model.ApplicationTypeOne.OneTextThree,
                    ["1Text4"] = model.ApplicationTypeOne.OneTextFour,
                    ["1Text5"] = model.ApplicationTypeOne.OneTextFive,
                    ["1Text6"] = model.ApplicationTypeOne.OneTextSix,
                    ["1Text7"] = model.ApplicationTypeOne.OneTextSeven,
                    ["1Text8"] = model.ApplicationTypeOne.OneTextEight,
                    ["1Text9"] = model.ApplicationTypeOne.OneTextNine,
                    ["1Text10"] = model.ApplicationTypeOne.OneTextTen,
                    ["1Text11"] = model.ApplicationTypeOne.OneTextEleven,
                    ["1Text12"] = model.ApplicationTypeOne.OneTextTwelve,
                    ["1Text13"] = model.ApplicationTypeOne.OneTextThirteen,
                    ["1Text14"] = model.ApplicationTypeOne.OneTextFourteen,
                    ["1Text15"] = model.ApplicationTypeOne.OneTextFithteen,

                    ["2Text1"] = model.ApplicationTypeOne.TwoTextOne,
                    ["2Text2"] = model.ApplicationTypeOne.TwoTextTwo,
                    ["2Text3"] = model.ApplicationTypeOne.TwoTextThree,
                    ["2Text4"] = model.ApplicationTypeOne.TwoTextFour,
                    ["2Text5"] = model.ApplicationTypeOne.TwoTextFive,
                    ["2Text6"] = model.ApplicationTypeOne.TwoTextSix,
                    ["2Text7"] = model.ApplicationTypeOne.TwoTextSeven,
                    ["2Text8"] = model.ApplicationTypeOne.TwoTextEight,
                    ["2Text9"] = model.ApplicationTypeOne.TwoTextNine,
                    ["2Text10"] = model.ApplicationTypeOne.TwoTextTen,
                    ["2Text11"] = model.ApplicationTypeOne.TwoTextEleven,
                    ["2Text12"] = model.ApplicationTypeOne.TwoTextTwelve,
                    ["2Text13"] = model.ApplicationTypeOne.TwoTextThirteen,
                    ["2Text14"] = model.ApplicationTypeOne.TwoTextFourteen,
                    ["2Text15"] = model.ApplicationTypeOne.TwoTextFithteen,
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