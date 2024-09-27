using Hotel.Data;
using Hotel.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    [Area("Master")]
    public class MasterCustomer : Controller
    {
        private HMSContext Hms;
        public MasterCustomer(HMSContext Hms)
        {
            this.Hms = Hms;
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.ListCustomer = Hms.Set<TblCustomer>();
            return View(model);
        }
    }
}
