using System;
using System.Web.Mvc;
using System.Web.Routing;
using Web.Data;

namespace Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("Scripts/{*pathInfo}");

            routes.MapRoute(
                "WoodyDebris",
                "Survey/{surveyId}/{controller}/{action}");

            routes.MapRoute(
                "WoodyDebrisWithId",
                "Survey/{surveyId}/{controller}/{action}/{id}", new {id = UrlParameter.Optional});
            
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Survey", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory());
        }

        public void Application_EndRequest()
        {
            Web.Services.Container.Resolve<ISessionFactoryFactory>().EndSession();
        }
        public class ControllerFactory : DefaultControllerFactory
        {
            protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
            {             
                if (controllerType != null)
                {
                    return (IController)Web.Services.Container.Resolve(controllerType);
                }
                return null;
            }
        }
    }
}