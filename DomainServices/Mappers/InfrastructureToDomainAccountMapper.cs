using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Models;
using WebApplication.Infrastructure.Models;

namespace DomainServices.Mappers
{
    public static class InfrastructureToDomainAccountMapper
    {
        public static DomainAccount ToDomain(this InfrastructureAccount @this)
        {
            return new DomainAccount
            {
                AccountId = @this.AccountId,
                Balance = @this.Balance,
                ClientId = @this.ClientId
            };
        }
    }
}
