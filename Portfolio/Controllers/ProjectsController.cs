using System.IO;
using System.Web.Mvc;
using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        private ApplicationDbContext _context;

        public ProjectsController()
        {
            _context =new ApplicationDbContext();
        }
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddProject()
        {

            return View();
        }

        public ActionResult Save(ProjectFormViewModel projectFormViewModel)
        {

            if (!ModelState.IsValid)
            {
                return View("AddProject", projectFormViewModel);
            }

            var path = "~/images/" + Path.GetFileName(projectFormViewModel.File.FileName);


            var project = new Project

            {
                Name = projectFormViewModel.Name,
                Description = projectFormViewModel.Description,
                Image = path

            };
            _context.Projects.Add(project);
            projectFormViewModel.File.SaveAs(Server.MapPath(path));
            _context.SaveChanges();

            return View("index");
        }
    }
}