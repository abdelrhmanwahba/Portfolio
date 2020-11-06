using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Portfolio.ViewModels
{
    public class ProjectFormViewModel
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }
        [Microsoft.Web.Mvc.FileExtensions(Extensions = ("png,jpg"),
            ErrorMessage = "Specify a png or jpg photo")]
        [Display(Name = "Project image")]
        [Required]

        public HttpPostedFileBase File { get; set; }
    }
}