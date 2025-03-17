using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zorrilla_Mission10.Data;

namespace Zorrilla_Mission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private BowlerDBContext _bowlContext;
        public BowlersController(BowlerDBContext temp) 
        {
            _bowlContext = temp;
        }

        [HttpGet(Name = "GetBowlerInfo")]
        public async Task<IEnumerable<BowlerCLass>> Get([FromQuery] string[] teamNames)
        {
            var bowlList = await _bowlContext.Bowlers
                .Include(b => b.Team)
                .Where(b => teamNames.Contains(b.Team.TeamName))
                .ToListAsync();

            return bowlList;
        }
    }
}
