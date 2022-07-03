using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class EligibilitySection
    {
        public Guid Id { get; set; }
        public bool HasInterest { get; set; }
        public int OptionValue { get; set; }
        public ICollection<NotifiedPerson> NotifiedPeople { get; set; }
    }
    
    public class NotifiedPerson
    {
        public Guid Id { get; set; }
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
