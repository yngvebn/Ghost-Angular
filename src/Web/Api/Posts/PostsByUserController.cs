using System.Web.Http;

namespace Web.Api.Posts
{
    [RoutePrefix("api/v1/users/{userId}/posts")]
    public class PostsByUserController : ApiController
    {
        [Route, HttpGet]
        public IHttpActionResult Get(int userId, int skip = 0, int take = 10)
        {
            return Ok();
        }
    }
}