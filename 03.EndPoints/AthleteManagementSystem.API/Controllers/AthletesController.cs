using AthleteManagementSystem.ApplicationService.Athletes;
using AthleteManagementSystem.Domain.Athletes.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AthleteManagementSystem.API.Controllers
{
    [Route("api/athletes")]
    [ApiController]
    public class AthletesController : ControllerBase
    {
        [HttpPost]
        public async Task Add(
            [FromServices] AddAthleteHandler handler,
            [FromBody] AddAtheleteDto dto)
        { 
            await handler.Handle(dto);
        }
    }
}
