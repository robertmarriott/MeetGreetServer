using MediatR;
using MeetGreetServer.Application.MeetGreetServer.Queries.GetMeetings;
using MeetGreetServer.Web.ApiModels.Meetings;
using Microsoft.AspNetCore.Mvc;

namespace MeetGreetServer.Web.Controllers;

public class MeetingsController : ControllerBase
{
    private readonly IMediator _mediator;

    public MeetingsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<MeetingsApiModel>> Get()
    {
        var meetings = await _mediator.Send(new GetMeetingsQuery());
    }

    // [HttpGet("{id")]
    // public async Task<ActionResult> Get(Guid id)
    // {
    //     return NoContent();
    // }
}
