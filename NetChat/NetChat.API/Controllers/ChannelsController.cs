using Microsoft.AspNetCore.Mvc;
using NetChat.Persistence;
using System;
using System.Linq;

namespace NetChat.API.Controllers
{
    [ApiController]
    [Route("api/channels")]
    public class ChannelsController : ControllerBase
    {
        private readonly DataContext _context;

        public ChannelsController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Get()
        {
            var channels = _context.Channels.ToList();

            return Ok(channels);
        }
    }
}
