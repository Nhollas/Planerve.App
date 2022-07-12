using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class EligibilitySectionDto
    {
        public bool HasInterest { get; set; }
        public int OptionValue { get; set; }
        public ICollection<NotifiedPersonDto> NotifiedPeople { get; set; }
    }

    public class NotifiedPersonDto
    {
        public string Name { get; set; }
        public string HouseName { get; set; }
        public string HouseNumber { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public DateTime NoticeServed { get; set; }
    }
}
