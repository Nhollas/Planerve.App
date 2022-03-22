using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationData.Commands.UpdateApplication
{
    public class UpdateApplicationCommand : IRequest
    {
        public Guid Id { get; set; }
        public string ApplicationName { get; set; }
        public string VersionNumber { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string FullAddress { get; set; }
        public string Postcode { get; set; }
        public string LocalAuthority { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
