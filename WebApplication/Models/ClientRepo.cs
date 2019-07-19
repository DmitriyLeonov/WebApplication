using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication.Models
{
    public class ClientRepo
    {
        public static ClientRepo clientRepo = new ClientRepo();

        public static ClientRepo Current
        {
            get{return clientRepo;}
        }

        public List<Client> clients = new List<Client>
        {
            new Client{ ClientId = 1, ClientName = "Dmitriy"},
            new Client{ ClientId = 2, ClientName = "Ivan"},
            new Client{ ClientId = 3, ClientName = "Petr"}
        };

        public IEnumerable<Client> GetAllClients()
        {
            return clients;
        }

        public Client GetClient(int id)
        {
            return clients.Where(_=>_.ClientId == id).FirstOrDefault();
        }

        [HttpPost]
        public Client CreateClient(int clientId)
        {
            Client client = new Client
            { ClientId = clientId, ClientName = "Vasiliy" };
            clients.Add(client);
            return client;
        }

        [HttpPut]
        public bool UpdateClient(int clientId)
        {
            Client client = GetClient(clientId);
            if (client != null)
            {
                client.ClientName = "Pavel";
                return true;
            }
            return false;
        }

        [HttpDelete]
        public void DeleteClient(int clientId)
        {
            Client client = GetClient(clientId);
            if(client != null)
            {
                clients.Remove(client);
            }
        }
    }
}