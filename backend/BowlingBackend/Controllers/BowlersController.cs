using BowlingBackend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlersController(IBowlerRepository temp) {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var bowlerData = _bowlerRepository.Bowlers.ToArray();

            // Filter the bowler data to include only bowlers belonging to the teams "Sharks" or "Marlins"
            var filteredBowlerData = bowlerData.Where(bowler => bowler.Teams.TeamName == "Sharks" || bowler.Teams.TeamName == "Marlins");

            return filteredBowlerData;
        }

    }
}
