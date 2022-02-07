using System;
using MediatR;

namespace Planerve.App.Core.Features.ApplicationData.Commands.DeleteApplication;

public class DeleteApplicationCommand : IRequest
{
    public Guid ApplicationId { get; set; }
}