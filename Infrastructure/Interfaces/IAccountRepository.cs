using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.Models;

namespace Infrastructure.Interfaces
{
    public interface IAccountRepository
    {
        IList<InfrastructureAccount> GetAccounts(int limit, int offset);
        InfrastructureAccount GetAccount(int accountId);
    }
}
