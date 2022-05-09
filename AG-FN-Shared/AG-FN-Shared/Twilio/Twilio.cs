using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Verify.V2.Service;

namespace AG_FishNet_Shared.Twilio
{
    public class Twilio
    {
        private static readonly NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();

        private readonly string _pathServiceSid;

        public Twilio(string accountSid, string authToken, string pathServiceId)
        {
            TwilioClient.Init(accountSid, authToken);
            _pathServiceSid = pathServiceId;
            // YEah
        }
        
        public Task<VerificationResource> SendPhoneCodeAsync(string phoneNumber)
        {
            var verification = VerificationResource.CreateAsync(
                to: phoneNumber,
                channel: "sms",
                pathServiceSid: _pathServiceSid
            );

            return verification;
        }

        public Task<VerificationCheckResource> ValidatePhoneCodeAsync(string phoneNumber, string code)
        {
            var verificationCheck = VerificationCheckResource.CreateAsync(
                to: phoneNumber,
                code: code,
                pathServiceSid: _pathServiceSid
            );

            return verificationCheck;
        }
    }
}