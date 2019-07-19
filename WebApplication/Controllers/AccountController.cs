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

        [Route("post/{account:int}")]
        public Account Post(int account)
        {
            return AccountRepo.Current.CreateAcount(account);
        }

        
        [Route("put/{accountId:int}")]
        public bool Put(int accountId)
        {
            return AccountRepo.Current.UpdateAccount(accountId);
        }

        
        [Route("delete/{accountId:int}")]
        public void Delete(int accountId)
        {
            AccountRepo.Current.RemoveAccount(accountId);
        }
    }
}
