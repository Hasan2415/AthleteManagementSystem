namespace AthleteManagementSystem.Domain.Athletes.Dto
{
    public class GetAllAthleteDto
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; } = default!;
        public string LastName { get; private set; } = default!;
        public string MobileNumber { get; private set; } = default!;
        public string NationalCode { get; private set; } = default!;
    }
}
