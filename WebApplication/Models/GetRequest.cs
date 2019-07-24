using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class GetRequest
    {
        public int? Limit { get; set; }
        public int? Offset { get; set; }
    }
}