using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class Student
    {
        [Required]
        public string firstName { get; set; } = String.Empty;
        [Required]
        public string lastName { get; set; } = String.Empty;
        [Required]
        public string grade { get; set; } = String.Empty;
    }
}
