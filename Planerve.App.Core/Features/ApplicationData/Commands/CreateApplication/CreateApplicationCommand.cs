using MediatR;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateApplication;

public class CreateApplicationCommand : IRequest<Guid>
{
    public string ApplicationReference { get; set; }
    public string ApplicationName { get; set; }
    public string OwnerId { get; set; }
    public string VersionNumber { get; set; }
    public int ApplicationType { get; set; }
    public DateTime Created { get; set; }
    public Address Address { get; set; }
    public List<AuthorisedUsers> AuthorisedUsers { get; set; }
}