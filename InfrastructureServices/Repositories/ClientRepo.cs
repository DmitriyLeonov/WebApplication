using System.Collections.Generic;
using System.Linq;
using WebApplication.Infrastructure.Models;

namespace WebApplication.Models
{
    public class ClientRepo
    {
        public static ClientRepo clientRepo = new ClientRepo();

        public static ClientRepo Current
        {
            get{return clientRepo;}
        }

        public List<InfrastructureClient> clients = new List<InfrastructureClient>
        {
            new InfrastructureClient{ ClientId = 1, ClientName = "Dmitriy"},
            new InfrastructureClient{ ClientId = 2, ClientName = "Ivan"},
            new InfrastructureClient{ ClientId = 3, ClientName = "Petr"}
        };

        public IEnumerable<InfrastructureClient> GetAllClients(int limit, int offset)
        {
            IEnumerable<InfrastructureClient> client;
            if (offset < clients.Count)
            {
                client = clients.Skip(offset).Take(limit);
            }
            else
            {
                client = Enumerable.Empty<InfrastructureClient>();
            }
            return client.ToList();
        }

        public InfrastructureClient GetClient(int id)
        {
            return clients.Where(_=>_.ClientId == id).FirstOrDefault();
        }

        
        public InfrastructureClient CreateClient(int clientId)
        {
            InfrastructureClient client = new InfrastructureClient
            { ClientId = clientId, ClientName = "Vasiliy" };
            clients.Add(client);
            return client;
        }

        
        public bool UpdateClient(int clientId)
        {
            InfrastructureClient client = GetClient(clientId);
            if (client != null)
            {
                client.ClientName = "Pavel";
                return true;
            }
            return false;
        }

        public void DeleteClient(int clientId)
        {
            InfrastructureClient client = GetClient(clientId);
            if(client != null)
            {
                clients.Remove(client);
            }
        }
    }
}