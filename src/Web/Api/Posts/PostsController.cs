using System.Web.Http;

namespace Web.Api.Posts
{
    [RoutePrefix("api/v1/posts")]
    public class PostsController : ApiController
    {
        [Route, HttpGet]
        public IHttpActionResult Get(int skip = 0, int take = 10)
        {
            return Ok();
        }

        [Route, HttpPost]
        public IHttpActionResult Create(PostViewModel post)
        {
            return Ok();
        }

    }
}