using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }
}
