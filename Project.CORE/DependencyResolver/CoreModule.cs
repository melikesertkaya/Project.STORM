using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Project.CORE.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.DependencyResolver
{

    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection collection)
        {
            collection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    
            collection.AddSingleton<Stopwatch>();
        }
    }
}
