using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.IoC
{
    public static class ServiceTool
    {
        /// <summary>
        /// Injectionları olusturmak için kullanılır.
        /// //Istedigimiz Interface'ın karsılıgını bu tool sayesınde alabiliriz.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
