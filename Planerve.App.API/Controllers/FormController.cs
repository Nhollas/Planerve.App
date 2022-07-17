using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.Core.Features.FormFeatures.Commands.Update;
using Planerve.App.Core.Features.FormFeatures.Queries.DownloadForm;
using Planerve.App.Core.Features.FormFeatures.Queries.GetFormById;
using System.Text.Json.Nodes;

namespace Planerve.App.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : Controller
    {
        private readonly IMediator _mediator;

        public FormController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Download/{id:guid}", Name = "DownloadFormById")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Download(Guid id)
        {
            var downloadQuery = new DownloadFormDetailQuery { Id = id };
            return Ok(await _mediator.Send(downloadQuery));
        }

        [HttpGet("Get/{id:guid}", Name = "GetFormById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<FormDetailVM>> GetById(Guid id)
        {
            var formQuery = new GetFormDetailQuery { FormId = id };
            return Ok(await _mediator.Send(formQuery));
        }

        [HttpPut("Update/{id:guid}/Section/{name}", Name ="UpdateFormSectionByName")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update(Guid id, string name, [FromBody] JsonObject content)
        {
            UpdateFormCommand command = new()
            {
                FormId = id,
                Section = name,
                Data = content
            };

            await _mediator.Send(command);
            return NoContent();
        }
    }
}