using Autofac;
using ProjectDI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac.Integration.Mvc;

namespace ProjectDI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Other configurations...

            // Create the container builder
            var builder = new ContainerBuilder();

            // Register MVC controllers
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // Optionally, register model binders, web abstractions, and view pages
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();

            // Register services
            builder.RegisterType<MyService>().As<IMyService>();

            // Build the container
            var container = builder.Build();

            // Set the dependency resolver to Autofac
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));




            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
