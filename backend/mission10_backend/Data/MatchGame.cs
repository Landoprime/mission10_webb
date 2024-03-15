using System;
using System.Collections.Generic;

namespace mission10_backend.Data;

public partial class MatchGame
{
    public int MatchId { get; set; }

    public short GameNumber { get; set; }

    public int? WinningTeamId { get; set; }

    public virtual TourneyMatch Match { get; set; } = null!;
}
