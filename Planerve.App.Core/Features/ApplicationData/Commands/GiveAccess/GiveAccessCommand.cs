using System;
using MediatR;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationData.Commands.GiveAccess;

public class GiveAccessCommand : IRequest
{
    public Guid ApplicationId { get; set; }
}