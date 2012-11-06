using System;
using System.Web.Mvc;
using System.Threading;
using System.Threading.Tasks;
using AsyncDemoMVC4.Models;
//using AsyncDemoMVC4.Services;

namespace AsyncDemoMVC4.Controllers
{
    public class UsersAsyncController : Controller
    {
        IUsersService _usersService;

        public UsersAsyncController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        //
        // GET: /UsersAsync/ListAsync

        public async Task<ActionResult> ListAsync()
        {
            return View("List", await _usersService.GetUsersAsync());
        }

        //
        // GET: /UsersAsync/ListCancelAsync

        [AsyncTimeout(2500)]
        [HandleError(ExceptionType = typeof(TimeoutException),
                                    View = "TimeoutError")]
        public async Task<ActionResult> ListCancelAsync(
            CancellationToken cancellationToken)
        {
            return View("List", 
                await _usersService.GetUsersAsync(cancellationToken));
        }

    }
}
