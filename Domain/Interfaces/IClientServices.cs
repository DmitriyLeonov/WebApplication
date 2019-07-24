using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Models;

namespace WebApplication.Domain.Interfaces
{
    public interface IClientServices
    {
        IList<DomainClient> SearchClients(SearchClientFilter filter);
        DomainClient GetClient(int clientId);
        DomainClient Post(int Client);
        bool Put(int ClientId);
        void Delete(int ClientId);
    }
}
