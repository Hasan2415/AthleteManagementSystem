using System.ComponentModel.DataAnnotations;

namespace AthleteManagementSystem.Domain.Athletes.Dto
{
    public class AddAtheleteDto
    {
        [Required]
        public string FirstName { get; set; } = default!;
        [Required]
        public string LastName { get; set; } = default!;
        [Required]
        public string MobileNumber { get; set; } = default!;
        [Required]
        public string NationalCode { get; set; } = default!;
    }
}
