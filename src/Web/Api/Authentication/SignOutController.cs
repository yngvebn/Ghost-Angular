using System.Web.Http;

namespace Web.Api.Authentication
{
    [RoutePrefix("api/v1/auth/signout")]
    public class SignOutController : ApiController
    {
        [Route, HttpPost]
        public IHttpActionResult SignOut()
        {
            return Ok();
        }
    }
}