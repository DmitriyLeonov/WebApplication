using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Domain.Models;
using WebApplication.Models;

namespace WebApplication.Mappers
{
    public static class DomainToClientModel
    {
        public static Client ToClientModel(this DomainClient @this)
        {
            return new Client
            {
                ClientId = @this.ClientId,
                ClientName = @this.ClientName
            };
        }
    }
}