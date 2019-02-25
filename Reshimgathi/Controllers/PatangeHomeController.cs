using System;
using System.Web.Http;
using Org.Apollo.Utility;

namespace Reshimgathi.Controllers
{
    public class PatangeHomeController : ApiController
    {
        private Guid getToken;

        [HttpGet]
       public string SendEmail(string token)
       {
            Guid authKey = new Guid("1e5cdf75-4b89-4cc1-8754-e421160c7ab4");
            Guid.TryParse(token, out getToken);
            if(authKey == getToken)
            {
                if (Internet.IsConnectionActive())
                {
                    if (SendEmail())
                        return "Script executed successfully";

                    return "Error in executing script.";
                }
                else
                {
                    return "There is no active internet connection.";
                }
            }
            
            return "Please pass valid token.";
        }

        private bool SendEmail()
        {
            string Subject = "Patange Home Alert : Someone interrupted infrared in mounted in your house.";
            string Body = GetBody();

            Mail m = new Mail();
            m.Send("smtp.gmail.com", "amitpatange88@gmail.com", "brYX67JhdmasdHyXy=", "patangehome@gmail.com", Subject, Body);

            return true;
        }

        private string GetBody()
        {
            string message = string.Empty;
            message += $"<h2>Stamp DateTime : {DateTime.Now} </h2>";

            return message;
        }
    }
}
