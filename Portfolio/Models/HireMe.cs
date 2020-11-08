using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Portfolio.Models
{
    public class HireMe
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Email")]
        public string FroMailAddress { get; set; }

        [Required]
        public string Subject { get; set; }
        
        [Required]
        public string Message { get; set; }
    }
}