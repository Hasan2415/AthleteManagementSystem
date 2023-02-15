using AthleteManagementSystem.Domain.Athletes.Contracts;
using AthleteManagementSystem.Domain.Athletes.Dto;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AthleteManagementSystem.SqlServer.Athletes
{
    public class DapperAthleteQueryRepository : AthleteQueryRepository
    {
        private readonly SqlConnection _connection;

        public DapperAthleteQueryRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<GetAllAthleteDto>> GetAll()
        {
            var query = "select id, firstName, lastName," +
                " mobileNumber, nationalCode from Athletes";
            var result = await _connection
                .QueryAsync<GetAllAthleteDto>(query);
            return result.ToList();
        }
    }
}
