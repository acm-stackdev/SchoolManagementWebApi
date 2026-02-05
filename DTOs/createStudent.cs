using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Api.DTOs
{
    public class CreateStudentDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email {get; set;}
    }
}  