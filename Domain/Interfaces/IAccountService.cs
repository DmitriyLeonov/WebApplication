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
    }
}
