using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Infrastructure.Models
{
    public class InfrastructureAccount
    {
        public int AccountId { get; set; }
        public int Balance { get; set; }
        public int ClientId { get; set; }
    }
}