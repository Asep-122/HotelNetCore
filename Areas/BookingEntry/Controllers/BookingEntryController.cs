﻿using Hotel.Data;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    [Area("BookingEntry")]
    public class BookingEntryController : Controller
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
