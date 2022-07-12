using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class SiteVisitSection
    {
        public Guid Id { get; set; }
        public bool SiteVisible { get; set; }
        public int AppointmentContactType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
