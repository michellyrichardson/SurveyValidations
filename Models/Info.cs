using System;
using System.ComponentModel.DataAnnotations;

namespace SurveyValidations.Models
{
    public class Info
    {
        [Required(ErrorMessage="Your name must be entered!")]
        [MinLength(2, ErrorMessage="Your name must be at least 2 characters long")]
        [Display(Name="Name: ")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Dojo Location: ")]
        public string Location { get; set; }

        [Required]
        [Display(Name="Preferred Language: ")]
        public string Language { get; set; }


        [MaxLength(20, ErrorMessage="You exceeded the maximum 20 characters.")]
        [Display(Name="Message: ")]
        public string Message { get; set; }
    }
}