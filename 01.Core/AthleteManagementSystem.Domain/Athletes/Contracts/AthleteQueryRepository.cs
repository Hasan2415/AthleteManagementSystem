using AthleteManagementSystem.Domain.Athletes.Dto;

namespace AthleteManagementSystem.Domain.Athletes.Contracts
{
    public interface AthleteQueryRepository 
    {
        public Task<List<GetAllAthleteDto>> GetAll();
    }
}
