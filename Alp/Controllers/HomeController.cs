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
            var sanitizedFileName = Sanitize(fileName);

            if (sanitizedFileName == null)
                return Json(JsonError(-1, "invalid file name"));

            var file = Server.MapPath("~/Content/Files/" + sanitizedFileName);

            if (System.IO.File.Exists(file))
                return File("~/Content/Files/" + sanitizedFileName, "application/pdf", sanitizedFileName);
            else
                return Json(JsonError(-1, "invalid file name"));
        }


        // 
        // POST: /Home/Email

        [HttpPost]
        public ActionResult ContectUsEmail(string name, string returnEmail, string subject, string message)
        {
            if (ValidateEmail(returnEmail) == false)
                return Json(JsonError(-1, "invalid return email"));

            var sanitizedReturnEmail = Sanitize(returnEmail);
            var sanitizedName = Sanitize(name);
            var sanitizedSubject = Sanitize(subject);
            var sanitizedMessage = Sanitize(message);

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

        private static string Sanitize(string input)
        {
            return Microsoft.Security.Application.Sanitizer.GetSafeHtmlFragment(input);
        }

        private static JsonErrorModel JsonError(int errorCode, string errorMessage)
        {
            return new JsonErrorModel()
            {
                ErrorCode = errorCode,
                ErrorMessage = errorMessage
            };
        }

    }

    public class JsonErrorModel
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
