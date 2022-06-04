using MediatR;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Commands.CreateApplication
{
    public class CreateApplicationCommand : IRequest<Guid>
    {
        public string ApplicationName { get; set; }
        public int ApplicationType { get; set; }
        public int ApplicationCategory { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string Postcode { get; set; }
    }
}