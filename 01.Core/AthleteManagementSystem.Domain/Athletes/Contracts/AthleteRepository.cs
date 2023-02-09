using AthleteManagementSystem.Domain.Athletes.Entities;

namespace AthleteManagementSystem.Domain.Athletes.Contracts
{
    public interface AthleteRepository
    {
        void Add(Athlete athlete);
    }
}
