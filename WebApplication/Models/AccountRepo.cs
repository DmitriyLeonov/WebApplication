using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication.Models
{
    public class AccountRepo
    {
        public static AccountRepo accountRepo = new AccountRepo();

        public static AccountRepo Current
        {
            get{return accountRepo;}
        }

        public List<Account> accounts = new List<Account>
        {
            new Account{ AccountId = 214, Balance = 740, ClientId = 1 },
            new Account{ AccountId = 125, Balance = 915, ClientId = 2 },
            new Account{ AccountId = 121, Balance = 87, ClientId = 3 },
        };

        public IEnumerable<Account> GetAccounts()
        {
            return accounts;
        }

        public Account GetAccountById(int? id)
        {
            return accounts.Where(_=>_.AccountId == id).FirstOrDefault();
        }

        [HttpPost]
        public Account CreateAcount(int accountId)
        {
            Account account = new Account
            {AccountId = accountId, Balance = new Random().Next(1000),
            ClientId = accounts.Count+1 };      
            accounts.Add(account);
            return account;
        }

        [HttpDelete]
        public void RemoveAccount(int accountId)
        {
            Account account = GetAccountById(accountId);
            if (account != null)
                accounts.Remove(account);
        }

        [HttpPut]
        public bool UpdateAccount(int accountId)
        {
            Account account = GetAccountById(accountId);
            if(account != null)
            {
                account.Balance += 400;
                return true;
            }
            return false;
        }
    }
}