using Microsoft.EntityFrameworkCore;
using System;
namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    [Owned]
    public class AdviceSection
    {
        public Guid Id { get; set; }
        public bool AdviceSought { get; set; }
        public string ContactTitle { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime Date { get; set; }
        public string AdviceDescription { get; set; }
    }
}
