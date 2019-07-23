using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Models;
using WebApplication.Infrastructure.Models;

namespace DomainServices.Mappers
{
    public static class InfrastructureToDomainClientMapper
    {
        public static DomainClient toDomain(this InfrastructureClient @this)
        {
                return new DomainClient
                {
                    ClientId = @this.ClientId,
                    ClientName = @this.ClientName
                };
        }
    }
}
