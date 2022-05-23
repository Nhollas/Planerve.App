using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;

public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
{
    private readonly IAsyncRepository<Application> _repository;
    private readonly IPostcodeService _postcodeService;
    private readonly IMapper _mapper;
    private readonly ILoggedInUserService _loggedInUserService;


    public CreateApplicationCommandHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService, IPostcodeService postcodeService)
    {
        _mapper = mapper;
        _repository = repository;
        _loggedInUserService = loggedInUserService;
        _postcodeService = postcodeService;
    }

    public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateApplicationCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
            throw new ValidationException(validationResult);

        var modifiedRequest = await GenerateDefaultData(request);

        var application = await _repository.AddAsync(modifiedRequest);

        return application.Id;
    }

    private async Task<Application> GenerateDefaultData(CreateApplicationCommand request)
    {
        // Grab userId from API user service.
        var userId = _loggedInUserService.UserId().Result;

        // Grab application address from API address service
        var postCodeData = await _postcodeService.ValidatePostcode(request.Postcode);

        if (postCodeData is null)
        {
            throw new NotFoundException(nameof(PostcodeDataDto), $"The postcode {request.Postcode} is not valid.");
        }

        var postcodeData = JsonSerializer.Deserialize<PostcodeDataDto>(postCodeData,
        new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        var addressData = _mapper.Map<Address>(postcodeData.result);

        addressData.AddressLineOne = request.AddressLineOne;
        addressData.AddressLineTwo = request.AddressLineTwo;
        addressData.AddressLineThree = request.AddressLineThree;

        ApplicationTypeHelper applicationTypeHelper = new();

        var applicationTypeInfo = applicationTypeHelper.GetTypeInfo(request.ApplicationType);

        // Create mock application.
        Application applicationToCreate = new()
        {
            ApplicationType = _mapper.Map<ApplicationType>(applicationTypeInfo),
            ApplicationName = request.ApplicationName,
            Address = addressData,
            VersionNumber = "V1",
            OwnerId = userId,
            ApplicationReference = await GenerateAppReference()
        };

        return applicationToCreate;
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