using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Domain.Models;

namespace WebApplication.Domain.Interfaces
{
    public interface IAccountService
    {
        IList<DomainAccount> SearchAccounts(SearchAccountFilter filter);
        DomainAccount GetAccount(int accountId);
        DomainAccount Post(int account);
        bool Put(int accountId);
        void Delete(int accountId);
    }
}
