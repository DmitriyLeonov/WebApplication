using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Domain.Models
{
    public class SearchClientFilter
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }
}
