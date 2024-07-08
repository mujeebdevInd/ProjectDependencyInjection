using Autofac;
using ProjectDI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDI
{
    public class Containerconfiguration
    {
        public static IContainer configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MyService>().As<IMyService>();
            return builder.Build();

        }
    }
}