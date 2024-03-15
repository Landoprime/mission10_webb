namespace mission10_backend.Data
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
        //Team GetTeamById(int? teamID);
    }
}

