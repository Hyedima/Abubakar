using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;

namespace TwilioPhone
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public void MakeCall()
        {
            // Your Account SID from twilio.com/console
            var accountSid = "AC1f05db609ba8398a8b1c3664fb8f38d0";

            // Your Auth Token from twilio.com/console
            var authToken = "d82287ecde01621d6a97454ed3ae12c0";

            try
            {
                TwilioClient.Init(accountSid, authToken);

                var call = CallResource.Create(
                    to: new PhoneNumber("+2348036420271"),
                    from: new PhoneNumber("+2347037736311"),
                    url: new Uri("http://27276fbf.ngrok.io/default/"));

                //Console.WriteLine(call.Sid.ToString());
                //Console.Write("Press any key to continue.");
                //Console.ReadKey();
            }
            catch (Exception n)
            {

            }

        }
    }
}
