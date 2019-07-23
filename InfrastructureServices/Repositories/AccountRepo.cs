using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Infrastructure.Models;

namespace WebApplication.Models
{
    public class AccountRepo
    {
        public static AccountRepo accountRepo = new AccountRepo();

        public static AccountRepo Current
        {
            get{return accountRepo;}
        }

        public List<InfrastructureAccount> accounts = new List<InfrastructureAccount>
        {
            new InfrastructureAccount{ AccountId = 214, Balance = 740, ClientId = 1 },
            new InfrastructureAccount{ AccountId = 125, Balance = 915, ClientId = 2 },
            new InfrastructureAccount{ AccountId = 121, Balance = 87, ClientId = 3 },
        };

        public IEnumerable<InfrastructureAccount> GetAccounts(int limit, int offset)
        {
            IEnumerable<InfrastructureAccount> account;
            if( offset < accounts.Count)
            {
                account = accounts.Skip(offset).Take(limit);
            }
            else
            {
                account = Enumerable.Empty<InfrastructureAccount>();
            }
            return account.ToList();
        }

        public InfrastructureAccount GetAccountById(int? id)
        {
            return accounts.Where(_=>_.AccountId == id).FirstOrDefault();
        }

        
        public InfrastructureAccount CreateAcount(int accountId)
        {
            InfrastructureAccount account = new InfrastructureAccount
            {AccountId = accountId, Balance = new Random().Next(1000),
            ClientId = accounts.Count+1 };      
            accounts.Add(account);
            return account;
        }

        
        public void RemoveAccount(int accountId)
        {
            InfrastructureAccount account = GetAccountById(accountId);
            if (account != null)
                accounts.Remove(account);
        }

        
        public bool UpdateAccount(int accountId)
        {
            InfrastructureAccount account = GetAccountById(accountId);
            if(account != null)
            {
                account.Balance += 400;
                return true;
            }
            return false;
        }
    }
}