using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using WebApplication.DependencyInjection;
using WebApplication.Domain.Interfaces;
using WebApplication.DomainServices.Services;

namespace DependencyInjection.Modules
{
    public class AccountDomainModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IAccountService, AccountDomainServices>(new HierarchicalLifetimeManager());
        }
    }
}
