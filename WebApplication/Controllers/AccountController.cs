using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [RoutePrefix("accounts")]
    public class AccountController : ApiController
    {
        [System.Web.Http.AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        [Route("")]
        public IEnumerable<Account> GetAccounts()
        {
            return AccountRepo.Current.GetAccounts();
        }

        [Route("{accountId:int}")]
        public Account GetAccount(int accountId)
        {
            return AccountRepo.Current.GetAccountById(accountId);
        }

        [Route("postAccount/{account:int}")]
        [HttpPost]
        public Account PostAccount(int account)
        {
            return AccountRepo.Current.CreateAcount(account);
        }

        [Route("putAccount/{accountId:int}")]
        [HttpPut]
        public bool PutAccount(int accountId)
        {
            return AccountRepo.Current.UpdateAccount(accountId);
        }

        [Route("account/{accountId:int}")]
        [HttpDelete]
        public void DeleteAccount(int accountId)
        {
            AccountRepo.Current.RemoveAccount(accountId);
        }
    }
}
