using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace LearnTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var accountSid = Secrets.accountSid;    //username
            var authToken = Secrets.authToken;    //account password
            var toNumber = Secrets.toNumber;
            var fromNumber = Secrets.fromNumber;

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toNumber),
                from: new PhoneNumber(fromNumber),
                body: "Hi just learned Twilio messaging!"
            );
        }
    }
}