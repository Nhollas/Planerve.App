﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class SiteSection
    {
        public Guid Id { get; set; }
        public bool AutoPopulated { get; set; }
        public string HouseNumber { get; set; }
        public string PropertyName { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string Easting { get; set; }
        public string Northing { get; set; }
        public string Description { get; set; }
    }
}