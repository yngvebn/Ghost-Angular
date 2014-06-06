using System.Collections.Generic;
using System.Web.Http;

namespace Web.Api.Users
{
    [RoutePrefix("api/v1/users")]
    public class UsersController : ApiController
    {
        [Route]
        public IHttpActionResult Get()
        {
            return null;
        }

        [Route, HttpPost]
        public IHttpActionResult Create(UserViewModel user)
        {
            return null;
        }
    }
}