namespace Alp.Controllers
{
    using System;
    using System.IO;
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
        // GET: /Home/Registration

        public ActionResult Registration()
        {
            return View();
        }


        //
        // POST: /Home/Download

        public ActionResult Download(string fileName)
        {
            var sanitizedFileName = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(fileName);
            var error = new JsonErrorModel
            {
                ErrorCode = -1,
                ErrorMessage = "invalid file name"
            };

            if (sanitizedFileName == null)
            {


                return Json(error);
            }

            var file = Server.MapPath("~/Content/Files/" + sanitizedFileName);
            if (System.IO.File.Exists(file))
                return File("~/Content/Files/" + sanitizedFileName, "application/pdf", sanitizedFileName);
            else
                return Json(error);


        }


        // 
        // POST: /Home/Email

        [HttpPost]
        public ActionResult ContectUsEmail(string name, string returnEmail, string subject, string message)
        {
            if (!ValidateEmail(returnEmail))
            {

                var error = new JsonErrorModel
                {
                    ErrorCode = -1,
                    ErrorMessage = "invalid return email"
                };

                return Json(error);
            }

            var sanitizedReturnEmail = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(returnEmail);
            var sanitizedName = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(name);
            var sanitizedSubject = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(subject);
            var sanitizedMessage = Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(message);
            // TODO: write format email method to generate http email from sanitized input
            var smtpClient = new SmtpClient();
            var email = new MailMessage()
            {
                From = new MailAddress(sanitizedReturnEmail),
                Subject = sanitizedSubject,
                Body = sanitizedMessage,
            };

            email.To.Add("test");
            smtpClient.Send(email);

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


    public class JsonErrorModel
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
