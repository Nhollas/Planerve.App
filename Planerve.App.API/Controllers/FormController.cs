﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeA;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeB;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeC;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeD;
using Planerve.App.Core.Features.FormFeatures.Commands.UpdateFormTypeE;
using Planerve.App.Core.Features.FormFeatures.Queries.DownloadForm;
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

        // TypeA
        [HttpPut("Update/TypeA/{id:guid}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] UpdateFormTypeACommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        // TypeB
        [HttpPut("Update/TypeB/{id:guid}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] UpdateFormTypeBCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        // TypeC
        [HttpPut("Update/TypeC/{id:guid}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] UpdateFormTypeCCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        // TypeD
        [HttpPut("Update/TypeD/{id:guid}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] UpdateFormTypeDCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        // TypeE
        [HttpPut("Update/TypeE/{id:guid}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] UpdateFormTypeECommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpGet("Download/{id:guid}")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Download(Guid id)
        {
            var downloadQuery = new DownloadFormDetailQuery { Id = id };
            return Ok(await _mediator.Send(downloadQuery));
        }

        [HttpGet("Get/{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<FormDetailVM>> GetById(Guid id, int type)
        {
            var formQuery = new GetFormDetailQuery { Id = id, Type = type };
            return Ok(await _mediator.Send(formQuery));
        }
    }
}