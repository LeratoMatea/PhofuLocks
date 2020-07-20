using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhofuLocks.Models;
using System.Net.Mail;


namespace PhofuLocks.Controllers
{
    public class ContactUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactView(Contact em)
        {
            string to = em.To;
            string subject = em.Subject;
            string body = em.Body;
            MailMessage mm = new MailMessage();
            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.From = new MailAddress("Leratomatea26@gmail.com");
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("leratomatea26@gmail.com", "Ler@t0m@tea1");
            smtp.Send(mm);
            ViewBag.message = "Email was sent to " + em.To + "Successfully";
            return View();
        }

    }
}
