using Hotel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models.Customer
{
    public class IndexViewModel
    {
        public IEnumerable<TblCustomer> ListCustomer { get; set; }
    }
}
