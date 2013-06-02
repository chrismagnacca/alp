namespace Alp.Controllers
{
    using System;
    using System.IO;
    using System.Collections.Specialized;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI.WebControls;
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
        // GET: /Home/Download

        public ActionResult DownloadFile(int fileId)
        {

            var fileName = "";

            switch (fileId)
            {
                case 1:
                    fileName = "2013-2014_registration_form.pdf";
                    break;
                case 2:
                    fileName = "2013-2014_school_calendar.pdf";
                    break;
            }

            var file = Server.MapPath("~/Content/Files/" + fileName);

            if (System.IO.File.Exists(file))
                return File("~/Content/Files/" + fileName, "application/pdf", fileName);

            return null;
        }

        // 
        // POST: /Home/ContactUsEmail

        [HttpPost]
        public ActionResult ContactUsEmail(string name, string returnEmail, string subject, string message)
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
                Body = sanitizedMessage
            };

            emailMessage.To.Add("chrismagnacca@gmail.com");

            SendEmail(emailMessage);

            return Json(true);
        }

        //
        // POST: /Home/RegistrationEmail

        [HttpPost]
        public ActionResult RegistrationEmail(string childName, string dateOfBirth, string maleFemale, string address, string city, string zip,
            string ageChild, string guardians, string telephone, string email, string enrollmentDays, string extendedCare, string extendedCareDaysTimes)
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

            var emailDefinition = new MailDefinition();

            emailDefinition.From = sanitizedEmail;
            emailDefinition.IsBodyHtml = true;
            emailDefinition.Subject = "Online Registration: " + sanitizedChildName;

            var replacements = new ListDictionary();

            replacements.Add("<%NameOfChild%>", sanitizedChildName);
            replacements.Add("<%DateOfBirth%>", sanitizedDateOfBirth);
            replacements.Add("<%Address%>", sanitizedAddress);
            replacements.Add("<%City%>", sanitizedCity);
            replacements.Add("<%Zip%>", sanitizedZip);
            replacements.Add("<%Telephone%>", sanitizedTelephone);
            replacements.Add("<%Email%>", sanitizedEmail);
            replacements.Add("<%Guardians%>", sanitizedGuardians);
            replacements.Add("<%AgeOfChild%>", sanitizedAgeChild);
            replacements.Add("<%Sex%>", sanitizedMaleFemale);
            replacements.Add("<%EnrollmentDays%>", sanitizedEnrollmentDays);
            replacements.Add("<%ExtendedCareInterest%>", sanitizedExtendedCare);
            replacements.Add("<%ExtendedCareTimes%>", sanitizedExtendedCareDaysTimes);

            string body = RenderPartialViewToString("_RegistrationEmail");

            var emailMessage = emailDefinition.CreateMailMessage("chrismagnacca@gmail.com", replacements, body, new System.Web.UI.Control());

            SendEmail(emailMessage);

            return Json(true);
        }

        private void SendEmail(MailMessage email)
        {
            var smtpClient = new SmtpClient();
            smtpClient.Send(email);
        }

        private string RenderPartialViewToString()
        {
            return RenderPartialViewToString(null, null);
        }

        private string RenderPartialViewToString(string viewName)
        {
            return RenderPartialViewToString(viewName, null);
        }

        private string RenderPartialViewToString(object model)
        {
            return RenderPartialViewToString(null, model);
        }

        private string RenderPartialViewToString(string viewName, object Model)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.RouteData.GetRequiredString("action");

            ViewData.Model = Model;

            using (StringWriter sw = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                return sw.GetStringBuilder().ToString();
            }
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
