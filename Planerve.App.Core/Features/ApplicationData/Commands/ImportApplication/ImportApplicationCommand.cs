using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Commands.ImportApplication
{
    public class ImportApplicationCommand : IRequest<Guid>
    {
        public string AccessToken { get; set; }
    }
}
