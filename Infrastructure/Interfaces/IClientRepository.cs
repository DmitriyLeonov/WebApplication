using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.Models;

namespace Infrastructure.Interfaces
{
    public interface IClientRepository
    {
        IList<InfrastructureClient> GetClients(int limit, int offset);
        InfrastructureClient GetClient(int clientId);
    }
}
