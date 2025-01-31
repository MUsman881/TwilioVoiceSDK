using Faker;
using Faker.Extensions;
using Microsoft.AspNetCore.Mvc;
using Quickstart.Models;
using Quickstart.Models.Configuration;
using Twilio.Jwt.AccessToken;

namespace SDKQuickstart.Controllers
{
    public class TokenController : Controller
    {

        private readonly TwilioAccountDetails? _twilioAccountDetails;

        public TokenController(IConfiguration twilioAccountDetails)
        {
            _twilioAccountDetails = twilioAccountDetails.GetSection("TwilioAccountDetails").Get<TwilioAccountDetails>();
        }

        // GET: /token
        [HttpGet]
        public IActionResult Index()
        {
            var identity = Internet.UserName().AlphanumericOnly();
            Device.Identity = identity;

            var grant = new VoiceGrant();
            grant.OutgoingApplicationSid = _twilioAccountDetails?.TwimlAppSid;
            grant.IncomingAllow = true;

            var grants = new HashSet<IGrant>
            {
                { grant }
            };

            var token = new Token(
                _twilioAccountDetails.AccountSid,
                _twilioAccountDetails.ApiSid,
                _twilioAccountDetails.ApiSecret,
                identity,
                grants: grants).ToJwt();

            return Json(new { identity, token });
        }
    }
}
