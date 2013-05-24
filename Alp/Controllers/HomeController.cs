using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using Typesafe.Mailgun;
using System.Text.RegularExpressions;

namespace Alp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/Directions/

        public ActionResult Directions()
        {
            return View();
        }

        //
        // GET: /Home/StaffAndFaculty

        public ActionResult StaffAndFaculty()
        {
            return View();
        }

        //
        // GET: /Home/SchoolCalendar

        public ActionResult SchoolCalendar()
        {
            return View();
        }


        // 
        // GET: /Home/ContactUs

        public ActionResult ContactUs()
        {
            return View();
        }

        // 
        // POST: /Home/Email
        [HttpPost]
        public ActionResult Email(string name, string returnEmail, string subject, string message)
        {
            MailMessage email = new MailMessage();
            if (!ValidateEmail(returnEmail))
            {
                return Json(false);
            }

            var client = new MailgunClient("smtp.mailgun.org", "key-0bh4d1wuo76b-9wugiyovi-yzjce0tf0");
            client.SendMail(new System.Net.Mail.MailMessage("test@samples.mailgun.org", "chrismagnacca@gmail.com")
            {
                Subject = "Hello from mailgun",
                Body = "this is a test message from mailgun."
            });

            return Json(true);
        }

        private static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email,
                 @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                 @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                 RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

        }


    }
}
