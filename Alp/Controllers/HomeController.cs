namespace Alp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Net.Mail;
    using System.Text.RegularExpressions;
    using SendGrid;
    using SendGrid.Transport;

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

            var composition = SendGrid.Mail.GetInstance();

            composition.From = new MailAddress("alp.apphb.com");

            List<String> recipients = new List<String>
            {
                sanitizedReturnEmail
            };

            composition.AddTo(recipients);
            composition.Subject = sanitizedSubject;
            composition.Text = sanitizedMessage;

            var sgu = "73304835-3006-4db9-98bd-873225a85f02@apphb.com";
            var sgp = "vdzs3kfd";

            var crd = new System.Net.NetworkCredential(sgu, sgp);

            var transport = SMTP.GetInstance(crd);
            transport.Deliver(composition);

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
