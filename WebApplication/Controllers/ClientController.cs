using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Domain.Interfaces;
using WebApplication.Domain.Models;
using WebApplication.Mappers;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [RoutePrefix("clients")]
    public class ClientController : ApiController
    {
        public readonly IClientServices _clientService;

        public ClientController(IClientServices clientService)
        {
            _clientService = clientService;
        }
        
        [HttpGet, Route("")]
        public List<Client> Get([FromUri] GetRequest request)
        {
            if (request == null)
                request = new GetRequest();
            var Clients = _clientService.SearchClients(new SearchClientFilter()
              {  
                Limit = request.Limit ?? 3,
                Offset = request.Offset ??0
              });
            return Clients.Select(_=>_.ToClientModel()).ToList();
        }

        [Route("{ClientId:int}")]
        public Client GetClient(int ClientId)
        {
            var Client = _clientService.GetClient(ClientId);
            return Client.ToClientModel();
        }

        [Route("post/{Client:int}")]
        public Client Post(int Client)
        {
            var Clients = _clientService.Post(Client);
            return Clients.ToClientModel();
        }

        
        [Route("put/{ClientId:int}")]
        public bool Put(int ClientId)
        {
            var Client = _clientService.Put(ClientId);
            return Client;
        }

        
        [Route("delete/{ClientId:int}")]
        public void Delete(int ClientId)
        {
            _clientService.Delete(ClientId);
        }
    }
}
