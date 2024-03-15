using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mission10_backend.Data;

namespace mission10_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingrepo;
        public BowlerLeagueController(IBowlingRepository temp)
        {
            _bowlingrepo = temp;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var joinData = from Bowler in _bowlingrepo.Bowlers
                           join Team in _bowlingrepo.Teams
                           on Bowler.TeamId equals Team.TeamId
                           where Team.TeamName == "Marlins" || Team.TeamName == "Sharks"
                           select new
                           {
                               BowlerId = Bowler.BowlerId,
                               BowlerLastName = Bowler.BowlerLastName,
                               BowlerFirstName = Bowler.BowlerFirstName,
                               BowlerMiddleInit = Bowler.BowlerMiddleInit,
                               BowlerAddress = Bowler.BowlerAddress,
                               BowlerCity = Bowler.BowlerCity,
                               BowlerState = Bowler.BowlerState,
                               BowlerZip = Bowler.BowlerZip,
                               BowlerPhoneNumber = Bowler.BowlerPhoneNumber,
                               TeamName = Team.TeamName

                           };
            return joinData.ToList();

        }
        //public IEnumerable<Bowler> Get()
        //{
        //    var bowlingData = _bowlingrepo.Bowlers.ToArray();
        //    return bowlingData;
        //}
    }
}

//public IEnumerable<Bowler> Get()
//{
//    var bowlingData = _bowlingrepo.Bowlers.ToArray();
//    return bowlingData;
//}

//public IEnumerable<Team> Get()
//{
//    var teamData = _bowlingrepo.Teams.ToArray();
//    return teamData;
//}
//    }
//}

//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using mission10_backend.Data;
//using System.Collections.Generic;

//namespace mission10_backend.Controllers
//{
//    [Route("[controller]")]
//    [ApiController]
//    public class BowlerLeagueController : ControllerBase
//    {
//        private readonly IBowlingRepository _bowlingrepo;

//        public BowlerLeagueController(IBowlingRepository temp)
//        {
//            _bowlingrepo = temp;
//        }

//        [HttpGet]
//        public IEnumerable<Bowler> Get()
//        {
//            var bowlers = _bowlingrepo.Bowlers;
//            foreach (var bowler in bowlers)
//            {
//                bowler.Team = _bowlingrepo.GetTeamById(bowler.TeamId);
//            }
//            return bowlers;
//        }
//    }
//}

//        [HttpGet]
//        public IActionResult Get()
//        {
//            var bowlingData = _bowlingrepo.JoinTheTables();

//            if (bowlingData == null || !bowlingData.Any())
//            {
//                return NoContent(); // No data found
//            }

//            return Ok(bowlingData);
//        }
//    }
//}





