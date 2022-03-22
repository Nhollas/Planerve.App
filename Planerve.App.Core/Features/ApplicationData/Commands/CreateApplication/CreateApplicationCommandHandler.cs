using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;

public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
{
    private readonly IAsyncRepository<Application> _repository;
    private readonly IPostcodeService _postcodeService;
    private readonly IMapper _mapper;
    private readonly ILoggedInUserService _loggedInUserService;
    private readonly IApplicationDataRepository _applicationDataRepository;


    public CreateApplicationCommandHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IApplicationDataRepository applicationDataRepository, IPostcodeService postcodeService)
    {
        _mapper = mapper;
        _repository = repository;
        _loggedInUserService = loggedInUserService;
        _applicationDataRepository = applicationDataRepository;
        _postcodeService = postcodeService;
    }

    public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
    {
        // Grab userId from API user service.
        var userId = _loggedInUserService.UserId;

        // Grab application address from API address service
        var addressInfo = await _postcodeService.ValidatePostcode(request.Address.Postcode);

        if (addressInfo == null) throw new NotFoundException(nameof(AddressDto), $"The postcode {request.Address.Postcode} is not valid.");

        request.Address.LocalAuthority = addressInfo.result.nuts;
        request.OwnerId = userId;

        var modifiedRequest = GenerateDefaultData(request).Result;

        var validator = new CreateApplicationCommandValidator(_applicationDataRepository);
        var validationResult = await validator.ValidateAsync(modifiedRequest, cancellationToken);

        if (validationResult.Errors.Count > 0)
            throw new ValidationException(validationResult);

        var application = _mapper.Map<Application>(modifiedRequest);

        application = await _repository.AddAsync(application);

        return application.Id;
    }

    private static Task<CreateApplicationCommand> GenerateDefaultData(CreateApplicationCommand model)
    {
        var appReference = GenerateAppReference();

        model.Created = DateTime.Now;
        model.VersionNumber = "V1";
        model.AuthorisedUsers[0].UserId = model.OwnerId;

        model.ApplicationReference = appReference.Result;

        return Task.FromResult(model);
    }

    private static Task<string> GenerateAppReference()
    {
        var r = new Random();
        var x = r.Next(0, 10000000);
        var s = x.ToString("0000000");
        var appReference = $"PP-{s}";

        return Task.FromResult(appReference);
    }
}