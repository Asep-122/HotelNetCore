using Hotel.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    public class BookingEntryController  d : Controller
    {
        private HMSContext HMS;

        public BookingEntryController(HMSContext HMS)
        {
            this.HMS = HMS;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
