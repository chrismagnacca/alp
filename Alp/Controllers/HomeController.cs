namespace Alp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Net.Mail;
    using System.Text.RegularExpressions;

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

            var sanitizedReturnEmail = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(returnEmail);
            var sanitizedName = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(name);
            var sanitizedSubject = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(subject);
            var sanitizedMessage = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(message);


            var smtpClient = new SmtpClient();
            var composition = new MailMessage()
            {
                From = new MailAddress(sanitizedReturnEmail),
                Subject = sanitizedMessage
            };

            composition.To.Add("chrismagnacca@gmail.com");
            
            smtpClient.Send(composition);

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
