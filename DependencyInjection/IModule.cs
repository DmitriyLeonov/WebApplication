using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.DependencyInjection
{
    interface IModule
    {
        void Register (IUnityContainer container);
    }
}
