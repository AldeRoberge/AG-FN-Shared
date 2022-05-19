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
                pathServiceSid: _pathServiceSid,
                to: phoneNumber,
                channel: "sms"
            );

            return verification;
        }

        public Task<VerificationCheckResource> ValidatePhoneCodeAsync(string phoneNumber, string code)
        {
            var verificationCheck = VerificationCheckResource.CreateAsync(
                pathServiceSid: _pathServiceSid,
                to: phoneNumber,
                code: code
            );

            Log.Info("[TWILIO] Path service sid: {0}", _pathServiceSid);

            return verificationCheck;
        }
    }
}