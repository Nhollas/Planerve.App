using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Dtos
{
    public class ApplicationTypeDto
    {
        public Guid Id { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
