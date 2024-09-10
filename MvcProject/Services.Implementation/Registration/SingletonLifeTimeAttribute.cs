using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace Services.Implementation.Registration
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class SingletonLifeTimeAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    class LifeTimeAttribute : Attribute
    {
        public ServiceLifetime LifetimeMode { get; set; }
    }
}
