using System.Collections.Generic;
using System.Web.Http;
using SlowService.Models;
using System.Threading;
//using System.ServiceModel.Web;

namespace SlowService.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/users
        public IEnumerable<User> Get()
        {
            IEnumerable<User> users = new List<User>{
                new User{Firstname="Fernando", Lastname="Alonso"},
                new User{Firstname="Alain", Lastname="Prost"},
                new User{Firstname="Emerson", Lastname="Fittipaldi"}
            };
            Thread.Sleep(5000);

            return users;
        }
    }
}
