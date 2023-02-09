using AthleteManagementSystem.Domain.Athletes.Contracts;
using AthleteManagementSystem.Domain.Athletes.Entities;

namespace AthleteManagementSystem.SqlServer.Athletes
{
    public class EFAthleteRepository : AthleteRepository
    {
        private readonly EFDataContext _context;

        public EFAthleteRepository(EFDataContext context)
        {
            _context = context;
        }

        public void Add(Athlete athlete)
        {
            _context.Athletes.Add(athlete);
        }
    }
}
