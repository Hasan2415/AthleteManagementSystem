namespace AthleteManagementSystem.Domain.Athletes
{
    public class Athlete
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string MobileNumber { get; set; } = default!;
        public string NationalCode { get; set; } = default!;
    }
}
