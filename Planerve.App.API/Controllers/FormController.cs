using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.Core.Features.FormData.Commands.CompleteForm;
using Planerve.App.Core.Features.FormData.Commands.UpdateForm;
using Planerve.App.Core.Features.FormData.Queries.GetFormById;
using System.Security.Claims;

namespace Planerve.App.API.Controllers;

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
    public async Task<ActionResult<FormCompletedVm>> GetById(Guid id)
    {
        var applicationQuery = new GetFormDetailQuery { Id = id };
        return Ok(await _mediator.Send(applicationQuery));
    }

    [HttpPut("CompleteForm", Name = "CompleteForm")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> CompleteForm([FromBody] CompleteFormCommand completeFormCommand)
    {
        await _mediator.Send(completeFormCommand);

        return NoContent();
    }

    [HttpPut(Name = "UpdateForm")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Update([FromBody] UpdateFormCommand updateFormCommand)
    {
        await _mediator.Send(updateFormCommand);
        return NoContent();
    }
}