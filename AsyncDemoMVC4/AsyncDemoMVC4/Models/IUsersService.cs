using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemoMVC4.Models
{
    public interface IUsersService
    {
       Task<List<User>> GetUsersAsync();

       Task<List<User>> GetUsersAsync(CancellationToken cancellationToken);
    }
}