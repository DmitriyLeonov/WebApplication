using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainServices.Services;
using Microsoft.Practices.Unity;
using WebApplication.DependencyInjection;
using WebApplication.Domain.Interfaces;
using WebApplication.DomainServices.Services;

namespace DependencyInjection.Modules
{
    public class ClientDomainModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IClientServices, ClientDomainServices>(new HierarchicalLifetimeManager());
        }
    }
}
