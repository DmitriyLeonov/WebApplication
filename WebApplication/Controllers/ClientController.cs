using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [RoutePrefix("clients")]
    public class ClientController : ApiController
    {
        [Route("")]
        public IEnumerable<Client> GetClients()
        {
            return ClientRepo.Current.GetAllClients();
        }

        [Route("{accountId:int}")]
        public Client GetClient(int accountId)
        {
            return ClientRepo.Current.GetClient(accountId);
        }

        [Route("post/{accountId:int}")]
        public Client Post(int accountId)
        {
            return ClientRepo.Current.CreateClient(accountId);
        }

        [Route("put/{accountId:int}")]
        public bool Put(int accountId)
        {
            return ClientRepo.Current.UpdateClient(accountId);
        }

        [Route("delete/{accountId:int}")]
        public void Delete(int accountId)
        {
            ClientRepo.Current.DeleteClient(accountId);
        }
    }
}
