using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using MonoCross.Navigation;
using MonoCross.Webkit;

namespace $safeprojectname$
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            // initialize app
            // example: MXWebkitContainer.Initialize(new HelloWorld.App());

            // add views to container
            MXWebkitContainer.AddView<string>(new Views.MessageView(), ViewPerspective.Default);
        }
    }
}
