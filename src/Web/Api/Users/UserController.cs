using System.Web.Http;

namespace Web.Api.Users
{
    [RoutePrefix("api/v1/users/{id}")]
    public class UserController : ApiController
    {
        [Route, HttpGet]
        public IHttpActionResult Get(int id)
        {
            return null;
        }

        [Route, HttpPut]
        public IHttpActionResult Update(int id, UserViewModel user)
        {
            return null;
        }

        [Route, HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            return null;
        }
    }
}