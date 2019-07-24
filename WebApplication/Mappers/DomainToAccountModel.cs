using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Domain.Models;
using WebApplication.Models;

namespace WebApplication.Mappers
{
    public static class DomainToAccountModel
    {
        public static Account ToModel(this DomainAccount @this)
        {
            return new Account
            {
                AccountId = @this.AccountId,
                Balance = @this.Balance,
                ClientId = @this.ClientId
            };
        }
    }
}