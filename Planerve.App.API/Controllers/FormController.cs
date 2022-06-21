using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.Core.Features.FormFeatures.Queries.GetFormById;

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

        [HttpGet("{id}", Name = "GetFormById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<FormDetailVm>> GetById(Guid id)
        {
            var applicationQuery = new GetFormDetailQuery { Id = id };
            return Ok(await _mediator.Send(applicationQuery));
        }
    }
}