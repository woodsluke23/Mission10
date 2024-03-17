
using Microsoft.EntityFrameworkCore;

namespace BowlingBackend.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlersContext _bowlerscontext;
        public EFBowlerRepository(BowlersContext temp)
        {
            _bowlerscontext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerscontext.Bowlers.Include(x => x.Teams);
        public IEnumerable<Team> Teams => _bowlerscontext.Teams;
    }
}
