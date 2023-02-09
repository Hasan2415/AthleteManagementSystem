using AthleteManagementSystem.Domain.Athletes.Contracts;
using AthleteManagementSystem.Domain.Athletes.Dto;
using AthleteManagementSystem.Domain.Athletes.Entities;
using AthleteManagementSystem.Framework.Domain.ApplicationServices;
using AthleteManagementSystem.Framework.Domain.Data;

namespace AthleteManagementSystem.ApplicationService.Athletes
{
    public class AddAthleteHandler : CommandHandler<AddAtheleteDto>
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly AthleteRepository _athleteRepository;

        public AddAthleteHandler(
            UnitOfWork unitOfWork, 
            AthleteRepository athleteRepository)
        {
            _unitOfWork = unitOfWork;
            _athleteRepository = athleteRepository;
        }

        public async Task Handle(AddAtheleteDto command)
        {
            var athlete = Athlete.Create(
                command.FirstName,
                command.LastName,
                command.MobileNumber,
                command.NationalCode);

            _athleteRepository.Add(athlete);
            await _unitOfWork.Complete();
        }
    }
}
