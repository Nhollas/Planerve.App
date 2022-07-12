using Planerve.App.Core.Features.FormFeatures.Commands.Update.Validators;
using Planerve.App.Core.Features.FormFeatures.Dtos.FormSections;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Actions
{
    public class UpdateSiteSection
    {
        private readonly IFormSectionService<SiteSection, SiteSectionDto> _sectionService;
        private readonly IAsyncRepository<SiteSection> _repository;

        public UpdateSiteSection(
            IFormSectionService<SiteSection, SiteSectionDto> sectionService,
            IAsyncRepository<SiteSection> repository)
        {
            _sectionService = sectionService;
            _repository = repository;
        }

        public async Task Update(JsonObject data, Guid id)
        {
            var formSectionToUpdate = await _repository.GetByIdAsync(id);

            SiteSectionDto deserializedFormSection = await _sectionService.DeserializeAsync(data, new SiteSectionDto());
            await _sectionService.ValidateAsync(deserializedFormSection, new SiteSectionValidator());
            SiteSection mappedSection = await _sectionService.MapAsync(formSectionToUpdate, deserializedFormSection);

            mappedSection.Id = id;

            await _repository.UpdateAsync(mappedSection);
        }
    }
}
