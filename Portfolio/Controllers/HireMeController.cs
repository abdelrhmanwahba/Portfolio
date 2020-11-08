using Portfolio.Models;
using System.Collections.Generic;
using System.Net.Mail;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HireMeController : Controller
    {
        private ApplicationDbContext _context;
        private List<SelectListItem> _subjects;
        public HireMeController()
        {
            _context = new ApplicationDbContext();
            _subjects = new List<SelectListItem>
            {
                new SelectListItem() {Text = "Asp.net developer", Value = "1"},
                new SelectListItem() {Text = "Software Engineer", Value = "2"},
                new SelectListItem() {Text = "Data Analyst", Value = "3"}
            };
        }


        // GET: HireMe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HireMeForm()
        {

            ViewBag.Subjects = _subjects;

            return View();
        }


        public ActionResult Save(HireMe model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Subjects = _subjects;
                return View("hiremeform");
            }
            

            _context.HireMeEmails.Add(model);
            _context.SaveChanges();

            return View("Index");
        }


        // void SendEmail(HireMe model)
        // {
        //
        //     MailMessage mailMessage = new MailMessage()
        //     {
        //         To = { new MailAddress("abdelrahman.khaled6949@gmail.com") },
        //         From = model.FroMailAddress,
        //         Body = model.Message,
        //         Subject = model.Subject,
        //     };
        //
        //     SmtpClient client = new SmtpClient("www.gmail.com", 2525)
        //     {
        //         Credentials = new NetworkCredential("abdelrahman.khaled6949@gmail.com", "0124206949"),
        //         EnableSsl = true
        //     };
        //     // code in brackets above needed if authentication required 
        //
        //     try
        //     {
        //         client.Send();
        //     }
        //     catch (SmtpException ex)
        //     {
        //         Console.WriteLine(ex.ToString());
        //     }
        // }
    }
}