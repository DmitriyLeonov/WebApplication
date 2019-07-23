using DomainServices.Mappers;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Interfaces;
using WebApplication.Domain.Models;

namespace WebApplication.DomainServices.Services
{
    public class AccountDomainServices : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountDomainServices(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public DomainAccount GetAccount(int accountId)
        {
            throw new NotImplementedException();
        }

        public IList<DomainAccount> SearchAccounts(SearchAccountFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentException("filter");
            }
             var accounts = _accountRepository.GetAccounts(filter.Limit, filter.Offset);
            return accounts.Select(_=>_.ToDomain()).ToList();
        }
    }
}
