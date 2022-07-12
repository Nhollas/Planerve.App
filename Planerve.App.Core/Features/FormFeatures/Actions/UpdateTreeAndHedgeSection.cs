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
    public class UpdateTreeAndHedgeSection
    {
        private readonly IFormSectionService<TreeAndHedgeSection, TreeAndHedgeSectionDto> _sectionService;
        private readonly IAsyncRepository<TreeAndHedgeSection> _repository;

        public UpdateTreeAndHedgeSection(
            IFormSectionService<TreeAndHedgeSection, TreeAndHedgeSectionDto> sectionService,
            IAsyncRepository<TreeAndHedgeSection> repository)
        {
            _sectionService = sectionService;
            _repository = repository;
        }

        public async Task Update(JsonObject data, Guid id)
        {
            var formSectionToUpdate = await _repository.GetByIdAsync(id);

            TreeAndHedgeSectionDto deserializedFormSection = await _sectionService.DeserializeAsync(data, new TreeAndHedgeSectionDto());
            await _sectionService.ValidateAsync(deserializedFormSection, new TreeAndHedgeSectionValidator());
            TreeAndHedgeSection mappedSection = await _sectionService.MapAsync(formSectionToUpdate, deserializedFormSection);

            mappedSection.Id = id;

            await _repository.UpdateAsync(mappedSection);
        }
    }
}
