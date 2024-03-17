﻿namespace BowlingBackend.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }

    }
}
