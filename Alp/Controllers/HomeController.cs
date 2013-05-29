namespace Alp.Controllers
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Net.Mail;
    using System.Text;
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
        // POST: /Home/ContectUsEmail

        [HttpPost]
        public ActionResult ContectUsEmail(string name, string returnEmail, string subject, string message)
        {
            var sanitizedReturnEmail = Sanitize(returnEmail);

            if (ValidateEmail(sanitizedReturnEmail) == false)
                return Json(JsonError(-1, "invalid return email"));
           
            var sanitizedName = Sanitize(name);
            var sanitizedSubject = Sanitize(subject);
            var sanitizedMessage = Sanitize(message);

            var emailMessage = new MailMessage()
            {
                From = new MailAddress(sanitizedReturnEmail),
                Subject = sanitizedSubject,
                Body = sanitizedMessage,
            };

            SendEmail(emailMessage);

            return Json(true);
        }

        //
        // POST: /Home/RegistrationEmail

        [HttpPost]
        public ActionResult RegistrationEmail(string childName, string dateOfBirth, string maleFemale, string address, string city, string zip,
            string ageChild, string guardians, string telephone, string email, string enrollmentDays, string extendedCare, string extendedCareDaysTimes )

        {
            var sanitizedEmail = Sanitize(email);

            if (ValidateEmail(sanitizedEmail) == false)
                return Json(JsonError(-1, "invalid return email"));

            var sanitizedChildName = Sanitize(childName);
            var sanitizedDateOfBirth = Sanitize(dateOfBirth);
            var sanitizedMaleFemale = Sanitize(maleFemale);
            var sanitizedAddress = Sanitize(address);
            var sanitizedCity = Sanitize(city);
            var sanitizedZip = Sanitize(zip);
            var sanitizedAgeChild = Sanitize(ageChild);
            var sanitizedGuardians = Sanitize(guardians);
            var sanitizedTelephone = Sanitize(telephone);
            var sanitizedEnrollmentDays = Sanitize(enrollmentDays);
            var sanitizedExtendedCare = Sanitize(extendedCare);
            var sanitizedExtendedCareDaysTimes = Sanitize(extendedCareDaysTimes);

            var mailBody = new StringBuilder();

            mailBody.AppendFormat("<h2>Online Registration: " + sanitizedChildName + "</h2>");
            mailBody.AppendFormat("<p>Name of Child: " + sanitizedChildName + "</p>");
            mailBody.AppendFormat("<p>Date of Birth: " + sanitizedDateOfBirth + "</p>");
            mailBody.AppendFormat("<p>Address: " + sanitizedAddress + "</p>");
            mailBody.AppendFormat("<p>City: " + sanitizedCity + "</p>");
            mailBody.AppendFormat("<p>Zip: " + sanitizedZip + "</p>");
            mailBody.AppendFormat("<p>Telephone: " + sanitizedTelephone + "</p>");
            mailBody.AppendFormat("<p>Name of parent(s) or guardian with whom child lives: " + sanitizedGuardians + "</p>");
            mailBody.AppendFormat("<p>Age on September 30, 2013: " + sanitizedAgeChild + "</p>");
            mailBody.AppendFormat("<p>Sex: " + sanitizedMaleFemale + "</p>");
            mailBody.AppendFormat("<p>Number of days per week of Enrollment: " + sanitizedEnrollmentDays + "</p>");
            mailBody.AppendFormat("<p>Are you interested in Extended Child Care?: " + sanitizedExtendedCare + "</p>");
            mailBody.AppendFormat("<p>If selecting YES, please list Days & Times: " + sanitizedExtendedCareDaysTimes+ "</p>");

            var emailMessage = new MailMessage()
            {
                From = new MailAddress(sanitizedEmail),
                Subject = "Online Registration: " + sanitizedChildName,
                Body = mailBody.ToString(),
            };

            SendEmail(emailMessage);

            return Json(true);
        }

        private void SendEmail(MailMessage email)
        {
            var smtpClient = new SmtpClient();
            email.To.Add("chrismagnacca@gmail.com");
            smtpClient.Send(email);
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
