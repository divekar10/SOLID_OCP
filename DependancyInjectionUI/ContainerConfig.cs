﻿using Autofac;
using DependancyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>()
                   .As<IApplication>();

            builder.RegisterType<BusinessLogic>()
                   .As<IBusinessLogic>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependancyInjection)))
                   .Where(t => t.Namespace.Contains("Utilities"))
                   .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
