using Hotel.Data;
using Hotel.Models.Fasilitas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Controllers
{
    public class MasterFasilitasController : Controller
    {
        private HMSContext HMS;

        string message = "";

        public MasterFasilitasController(HMSContext HMS){
            this.HMS = HMS;
        }
        public IActionResult Index()
        {
            var Models = new FasilitasEditViewModels(){

                 FasilitasBisnis = HMS.Query<TblFasilitasBisinis>(),
                 FasilitasPublik = HMS.Query<TblFasilitasPublik>(),
                 FasilitasUmum = HMS.Query<TblFasilitasUmum>(),
                 FasilitasMakanan = HMS.Query<TblFasilitasMakanan>(),
                 FasilitasTransportasi = HMS.Query<TblFasilitasTransportasi>(),
                 FasilitasKamar = HMS.Query<TblFasilitasKamar>(),
            };


           return View(Models);     
        }

        [HttpGet]
        public IActionResult CreatePopUpBisnis()
        {
            var model = new FasilitasEditViewModels();

            return PartialView("PopUpBisnis",model);
        }

        [HttpPost]
        public IActionResult CreatePopUpBisnis(IFormCollection form, TblFasilitasBisinis model)
        {
            try
            {
                HMS.Add(model);
                HMS.SaveChanges();
                message = "Success";
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }

            return Json(message);
        }

        [HttpGet]
        public IActionResult EditPopUpBisnis(int Id)
        {
            var model = new FasilitasEditViewModels();

            var data = HMS.Query<TblFasilitasBisinis>().Where(x => x.Id == Id).FirstOrDefault();

            model.JenisFasilitas = data.Fasilitas;
            model.Description = data.Description;

            return PartialView("PopUpBisnis",model);
        }

        [HttpPost]
        public IActionResult EditPopUpBisnis(IFormCollection form,TblFasilitasBisinis models)
        {

            try
            {
                var data = HMS.Query<TblFasilitasBisinis>().Where(x => x.Id == models.Id).FirstOrDefault();

                data.Fasilitas = models.Fasilitas;
                data.Description = models.Description;
                HMS.Update(data);
                HMS.SaveChanges();
                message = "Has Been Update";
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }

            return Json(message);
        }

    }

}
