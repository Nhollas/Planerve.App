using FluentValidation;
using System;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Planerve.App.Core.Interfaces.Services
{
    public interface IFormSectionService<TSection, TDto>
        where TSection : class
        where TDto : class
    {
        Task<TDto> DeserializeAsync(JsonObject data, TDto type);
        Task ValidateAsync(TDto entity, AbstractValidator<TDto> validator);
        Task<TSection> MapAsync(TSection mapType, TDto sectionDto);
    }
}
