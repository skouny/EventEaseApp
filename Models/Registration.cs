using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", 
            ErrorMessage = "Phone number must be in format: (123) 456-7890 or 123-456-7890")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select an event")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid event")]
        public int EventId { get; set; }

        public string? Company { get; set; }

        [StringLength(500, ErrorMessage = "Special requirements cannot exceed 500 characters")]
        public string? SpecialRequirements { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}
