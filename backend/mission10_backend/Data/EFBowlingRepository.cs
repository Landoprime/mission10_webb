namespace mission10_backend.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _Context;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _Context = temp;
        }
        public IEnumerable<Bowler> Bowlers => _Context.Bowlers;
        public IEnumerable<Team> Teams => _Context.Teams;
    }
}

        //using System.Collections.Generic;
//using System.Linq;

//namespace mission10_backend.Data
//{
//    public class EFBowlingRepository : IBowlingRepository
//    {
//        private BowlingLeagueContext _context;

//        public EFBowlingRepository(BowlingLeagueContext context)
//        {
//            _context = context;
//        }

//        public IEnumerable<Bowler> Bowlers => _context.Bowlers;

//        public IEnumerable<Team> Teams => _context.Teams;


//        public Team GetTeamById(int? teamID)
//        {
//            return _context.Teams.Find(teamID);
//        }
//    }
//}
