using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class HazardousSubstanceSection
    {
        public Guid Id { get; set; }
        public bool InvolvesHazardousSubstances { get; set; }
        public ICollection<Substance> Substances { get; set; }
    }

    public class Substance
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
