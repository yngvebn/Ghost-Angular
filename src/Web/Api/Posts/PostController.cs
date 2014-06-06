using System.Web.Http;

namespace Web.Api.Posts
{
    [RoutePrefix("api/v1/post/{id}")]
    public class PostController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        public IHttpActionResult Update(int id, PostViewModel post)
        {
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}