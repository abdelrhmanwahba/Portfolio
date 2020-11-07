using System.Net.Mail;

namespace Portfolio.Models
{
    public class HireMe
    {
        public int Id { get; set; }
        public MailAddress FroMailAddress { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }
    }
}