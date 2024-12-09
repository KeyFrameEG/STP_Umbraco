using System.ComponentModel.DataAnnotations;

namespace STPERI.Models
{
    public class NewsletterFormModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
