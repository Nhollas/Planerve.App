using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Exceptions;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;

public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
{
    private readonly IApplicationDataRepository _appDataRepository;
    private readonly IMapper _mapper;


    public CreateApplicationCommandHandler(IMapper mapper, IApplicationDataRepository appDataRepository)
    {
        _mapper = mapper;
        _appDataRepository = appDataRepository;
    }

    public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
    {
        var modifiedRequest = GenerateDefaultData(request, cancellationToken);

        var validator = new CreateApplicationCommandValidator(_appDataRepository);
        var validationResult = await validator.ValidateAsync(modifiedRequest.Result, cancellationToken);

        if (validationResult.Errors.Count > 0)
            throw new ValidationException(validationResult);

        var application = _mapper.Map<Application>(request);

        application = await _appDataRepository.AddAsync(application);

        return application.Id;
    }

    private Task<CreateApplicationCommand> GenerateDefaultData(CreateApplicationCommand model, CancellationToken cancellationToken)
    {
        var appReference = GenerateAppReference();

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