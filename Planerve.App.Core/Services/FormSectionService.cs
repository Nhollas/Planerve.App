using AutoMapper;
using FluentValidation;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;


namespace Planerve.App.Core.Services
{
    public class FormSectionService<TSection, TDto> : IFormSectionService<TSection, TDto> 
        where TSection : class 
        where TDto : class
    {
        private readonly IMapper _mapper;

        public FormSectionService(
            IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<TDto> DeserializeAsync(JsonObject data, TDto type)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            TDto deserialisedDto = data.Deserialize<TDto>(options);

            return Task.FromResult(deserialisedDto);
        }

        public Task<TSection> MapAsync(TSection sectionToUpdate, TDto sectionDto)
        {
            _mapper.Map(sectionDto, sectionToUpdate, typeof(TDto), typeof(TSection));

            return Task.FromResult(sectionToUpdate);
        }

        public async Task ValidateAsync(TDto entity, AbstractValidator<TDto> validator)
        {
            var validationResult = await validator.ValidateAsync(entity);

            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);
        }
    }
}
