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
    [RoutePrefix("accounts")]
    public class AccountController : ApiController
    {
        public readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        [HttpGet, Route("")]
        public List<Account> Get([FromUri] GetRequest request)
        {
            if (request == null)
                request = new GetRequest();
            var accounts = _accountService.SearchAccounts(new SearchAccountFilter()
              {  
                Limit = request.Limit ?? 3,
                Offset = request.Offset ??0
              });
            return accounts.Select(_=>_.ToModel()).ToList();
        }

        [Route("{accountId:int}")]
        public Account GetAccount(int accountId)
        {
            var account = _accountService.GetAccount(accountId);
            return account.ToModel();
        }

        [Route("post/{account:int}")]
        public Account Post(int account)
        {
            var accounts = _accountService.Post(account);
            return accounts.ToModel();
        }

        
        [Route("put/{accountId:int}")]
        public bool Put(int accountId)
        {
            var account = _accountService.Put(accountId);
            return account;
        }

        
        [Route("delete/{accountId:int}")]
        public void Delete(int accountId)
        {
            _accountService.Delete(accountId);
        }
    }
}
