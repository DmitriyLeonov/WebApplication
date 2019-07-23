using DomainServices.Mappers;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Interfaces;
using WebApplication.Domain.Models;

namespace DomainServices.Services
{
    public class ClientDomainServices: IClientServices
    {
        private static IClientRepository _clientRepository;

        public ClientDomainServices(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public DomainClient GetClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public IList<DomainClient> SearchClients(SearchClientFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentException("filter");
            }

            var clients = _clientRepository.GetClients(filter.Limit, filter.Offset);
            return clients.Select(_=>_.toDomain()).ToList();
        }
    }
}
