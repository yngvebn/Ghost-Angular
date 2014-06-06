using System.Web.Http;

namespace Web.Api.Authentication
{
    [RoutePrefix("api/v1/auth/signin")]
    public class SignInController: ApiController
    {
        [Route, HttpPost]
        public IHttpActionResult SignIn(SignInViewModel model)
        {
            return Ok();
        }
    }
}