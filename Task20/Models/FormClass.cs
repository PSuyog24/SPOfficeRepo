using System.ComponentModel.DataAnnotations;

namespace Task20.Models
{
    public class FormClass
    {
        [Required(ErrorMessage ="Username is required")]
        public string? Username { get; set; }
        public string? Address { get; set; }
        [Required(ErrorMessage ="Please Select Date")]
        [ValidateDate]
        public DateTime Date { get; set; }
        public List<string>? Nationality { get; set; }
        public string? PrefCountry { get; set; }
        public string? Skills { get; set;}
    }

    public class ValidateDate: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? date, ValidationContext validationContext)
        {
            return ((DateTime)date >= Convert.ToDateTime("1900-01-01") && (DateTime)date <= Convert.ToDateTime("2090-01-01"))? ValidationResult.Success: new ValidationResult("Date should be between 01-01-1900 to 01-01-2090");
        }
    }
}
