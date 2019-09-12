using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.TwiML;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace TwilioApp
{
    class TwilioClass
    {
        public TwilioClass()
        {
        }

        public void MakeCall(string personName)
        {
            // Your Account SID from twilio.com/console
            var accountSid = "AC1f05db609ba8398a8b1c3664fb8f38d0";

            // Your Auth Token from twilio.com/console
            var authToken = "d82287ecde01621d6a97454ed3ae12c0";

            try
            {
                //TwilioClient.Init(accountSid, authToken);
                //var call = CallResource.Create(
                //    to: new PhoneNumber("+2348036420271"),
                //    //to: new PhoneNumber("+2347037736311"),
                //    from: new PhoneNumber("+2347037736311"),
                //    url: new Uri("http://f491f4b1.ngrok.io/ids.ng/demo.xml"));

                //string callID = call.Sid.ToString();

                var twilio = new TwilioRestClient(accountSid, authToken);


                CallOptions options = new CallOptions();

                



                //                var twilio = new TwilioRestClient(accountSid, authToken);

                //              CallOptions options = new CallOptions();

            }
            catch (Exception n)
            {

            }


        }
    }
}
