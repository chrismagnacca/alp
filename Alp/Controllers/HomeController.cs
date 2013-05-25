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

            var sanitizedReturnEmail = new System.Net.Mail.MailAddress(Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(returnEmail));
            var sanitizedName = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(name);
            var sanitizedSubject = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(subject);
            var sanitizedMessage = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(message);

            var client = new MailgunClient("http://smtp.mailgun.org:587/", "key-0bh4d1wuo76b-9wugiyovi-yzjce0tf0");
            client.SendMail(new System.Net.Mail.MailMessage("postmaster@app12260.mailgun.org", "chrismagnacca@gmail.com")
            {
                Subject = sanitizedSubject,
                Body = sanitizedMessage,
                From = sanitizedReturnEmail
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
