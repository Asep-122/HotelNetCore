﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    [Area("Master")]
    public class MasterRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
