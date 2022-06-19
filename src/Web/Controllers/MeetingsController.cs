using Microsoft.AspNetCore.Mvc;

namespace MeetGreetServer.Web.Controllers;

public class MeetingsController : ApiControllerBase
{
    public MeetingsController()
    {
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return NoContent();
    }

    [HttpGet("{id")]
    public async Task<ActionResult> Get(Guid id)
    {
        return NoContent();
    }
}
