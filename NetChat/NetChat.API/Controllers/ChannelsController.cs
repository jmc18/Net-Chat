using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetChat.Persistence;
using System;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Get()
        {
            var channels = await _context.Channels.ToListAsync();

            return Ok(channels);
        }
    }
}
