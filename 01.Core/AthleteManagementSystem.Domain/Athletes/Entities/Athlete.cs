namespace AthleteManagementSystem.Domain.Athletes.Entities
{
    public class Athlete
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; } = default!;
        public string LastName { get; private set; } = default!;
        public string MobileNumber { get; private set; } = default!;
        public string NationalCode { get; private set; } = default!;

        private Athlete()
        {

        }

        private Athlete(
            string firstName,
            string lastName,
            string mobileNumber,
            string nationalCode)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            NationalCode = nationalCode;
        }

        public static Athlete Create(
            string firstName,
            string lastName,
            string mobileNumber,
            string nationalCode)
        {
            return new Athlete(
                firstName,
                lastName,
                mobileNumber,
                nationalCode);
        }
    }
}
