using Hotel.Data;
using Microsoft.AspNetCore.Mvc;
using Hotel.Models.Reservation;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Controllers
{
    [Area("Reservation")]
    public class ReservationController : Controller
    {
        HMSContext HMS;
        public ReservationController(HMSContext HMS)
        {
            this.HMS = HMS;
        }

        public IActionResult Index()
        {

            var getReservation = HMS.Set<TblReservation>().Select(x => new { KdReservation = x.KdReservation.Replace("RSV", "") });
            string KodeReservation = "";
            if (getReservation.Count() == 0)
            {
                KodeReservation = "RSV0001";
            }
            else
            {
                int nextKode = Convert.ToInt32(getReservation.Max().KdReservation) + 1;
                KodeReservation = "RSV" + nextKode;
            }


            var model = new CreateEditViewModel()
            {
                KdReservation = KodeReservation,
                TglReservasi = DateTime.Now,
                StartFrom = DateTime.Now,
                EndTo = DateTime.Now,
                ListKamar = HMS.Set<TblMasterKamar>().ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SaveReservarsi(CreateEditViewModel Model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return Json("data");
        }
    }
}
