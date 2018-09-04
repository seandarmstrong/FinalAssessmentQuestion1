using System.ComponentModel.DataAnnotations;

namespace FinalAssessmentQuestion1.Models
{
    public class NumberViewModel
    {
        [Required]
        [Range(1, 1000, ErrorMessage = "Please enter an integer between 1 and 1000")]
        public int Number1 { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Please enter an integer between 1 and 1000")]
        public int Number2 { get; set; }
    }
}