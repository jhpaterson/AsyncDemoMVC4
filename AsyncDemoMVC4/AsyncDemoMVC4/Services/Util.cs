
namespace AsyncDemoMVC4.Services
{
    public static class Util
    {
        public static string getRootUri()
        {
            // For IIS Express, use localhost:7734 
            var uri = "http://localhost:3768/";
            return uri;
        }

        public static string getServiceUri(string srv)
        {
            return getRootUri() + "api/" + srv;
        }
    }
}