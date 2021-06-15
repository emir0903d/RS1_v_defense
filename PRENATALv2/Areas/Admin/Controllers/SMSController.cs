using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nexmo.Api;
using System.Diagnostics;
using Vonage.Messaging;
using Vonage.Request;

namespace PRENATALv2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Patient, Doctor, Nurse, patient, doctor, nurse")]
    [AutoValidateAntiforgeryToken]
    public class SMSController : Controller
    {
        public IConfiguration _configuration { get; set; }

        public SMSController(IConfiguration config)
        {
            _configuration = config;
        }


        [HttpPost]
        //public bool Send(string to, string text)
        //{
        //    if(to==null || text == null)
        //    {
        //        return false;
        //    }
        //    SMS.Send(new SMS.SMSRequest
        //    {
        //        from = Configuration.Instance.Settings["appsettings:NEXMO_FROM_NUMBER"],
        //        to = to,
        //        text = text
        //    });

        //    return true;
        //}
        public bool Send(string to, string text)
        {
           
            var VONAGE_API_KEY = _configuration["VONAGE_API_KEY"];
            var VONAGE_API_SECRET = _configuration["VONAGE_API_SECRET"];
            var credentials = Credentials.FromApiKeyAndSecret(VONAGE_API_KEY, VONAGE_API_SECRET);
            var client = new SmsClient(credentials);
            var request = new SendSmsRequest { To = to, From ="Prenatal" , Text = text };
            var response = client.SendAnSms(request);
          
            if (response == null)
            {
                return false;
            }
            return true;
        }

    }
}