using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Project
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }
        public string Description { get; set; }
    }
}