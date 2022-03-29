using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Commands.CreateAccessToken;

public class CreateAccessTokenCommand : IRequest<string>
{
    public Guid ApplicationId { get; set; }
    public DateTime TokenLifetime { get; set; }
    public int TokenUses { get; set; }
}