using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Domain.Models
{
    public class DomainAccount
    {
        public int AccountId { get; set; }
        public int Balance { get; set; }
        public int ClientId { get; set; }
    }
}