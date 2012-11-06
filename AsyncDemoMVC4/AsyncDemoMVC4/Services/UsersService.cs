using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AsyncDemoMVC4.Models;

namespace AsyncDemoMVC4.Services
{
    public class UsersService : IUsersService
    {
        public async Task<List<User>> GetUsersAsync()
        {
            var uri = Util.getServiceUri("users");
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                return (await response.Content.ReadAsAsync<List<User>>());
            }
        }

        public async Task<List<User>> GetUsersAsync(
            CancellationToken cancelToken = default(CancellationToken))
        {
            var uri = Util.getServiceUri("users");
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri,cancelToken);
                return (await response.Content.ReadAsAsync<List<User>>());
            }
        }
    }
}