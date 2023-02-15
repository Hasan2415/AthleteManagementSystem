using AthleteManagementSystem.ApplicationService.Athletes;
using AthleteManagementSystem.Domain.Athletes.Contracts;
using AthleteManagementSystem.Domain.Athletes.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AthleteManagementSystem.API.Controllers
{
    [Route("api/athletes")]
    [ApiController]
    public class AthletesController : ControllerBase
    {
        private readonly AthleteQueryRepository _queryRepository;

        public AthletesController(AthleteQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        [HttpPost]
        public async Task Add(
            [FromServices] AddAthleteHandler handler,
            [FromBody] AddAtheleteDto dto)
        { 
            await handler.Handle(dto);
        }

        [HttpGet]
        public async Task<List<GetAllAthleteDto>> GetAll()
        {
            return await _queryRepository.GetAll();
        }
    }
}
