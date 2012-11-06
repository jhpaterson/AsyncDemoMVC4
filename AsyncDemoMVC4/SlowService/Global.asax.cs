using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApiContrib.Formatting;

namespace SlowService
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // this example needs JSONP support in WebAPI
            // in RC this involves adding the following lines
            // JsonpMediaTypeFormatter is part of WebApiContrib, which can be installed with nuget
            // not sure why Clear() is needed, but doesn't work without (i.e. doesn't wrap with callback function
            // name, e.g. jQuery generated name)
            // see http://forums.asp.net/t/1800542.aspx/1 for a discussion of this
            // call with ?callback=? appended to URL to let JsonpMediaTypeFormatter know about jsonp call,
            // e.g. http://localhost/3768/api/users?callback=?
            // NOTE that this all works for RC, may be different in release!
            var config = GlobalConfiguration.Configuration;
            config.Formatters.Clear();
            config.Formatters.Insert(0, new JsonpMediaTypeFormatter());

        }
    }
}