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
    [Area("Master")]
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

                 FasilitasBisnis = HMS.Set<TblFasilitasBisinis>(),
                 FasilitasPublik = HMS.Set<TblFasilitasPublik>(),
                 FasilitasUmum = HMS.Set<TblFasilitasUmum>(),
                 FasilitasMakanan = HMS.Set<TblFasilitasMakanan>(),
                 FasilitasTransportasi = HMS.Set<TblFasilitasTransportasi>(),
                 FasilitasKamar = HMS.Set<TblFasilitasKamar>()
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

            var data = HMS.Set<TblFasilitasBisinis>().Where(x => x.Id == Id).FirstOrDefault();

            model.JenisFasilitas = data.Fasilitas;
            model.Description = data.Description;

            return PartialView("PopUpBisnis",model);
        }

        [HttpPost]
        public IActionResult EditPopUpBisnis(IFormCollection form,TblFasilitasBisinis models)
        {

            try
            {
                var data = HMS.Set<TblFasilitasBisinis>().Where(x => x.Id == models.Id).FirstOrDefault();

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

        [HttpGet]
        public IActionResult CreatePopUpPublik()
        {
            var model = new FasilitasEditViewModels();

            return PartialView("PopUpPublik",model);
        }

        [HttpPost]
        public IActionResult CreatePopUpPublik(IFormCollection form, TblFasilitasPublik model)
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
        public IActionResult EditPopUpPublik(int Id)
        {
            var model = new FasilitasEditViewModels();

            var data = HMS.Set<TblFasilitasPublik>().Where(x => x.Id == Id).FirstOrDefault();

            model.JenisFasilitas = data.Fasilitas;
            model.Description = data.Description;

            return PartialView("PopUpBisnis",model);
        }

        [HttpPost]
        public IActionResult EditPopUpPublik(IFormCollection form,TblFasilitasPublik models)
        {

            try
            {
                var data = HMS.Set<TblFasilitasPublik>().Where(x => x.Id == models.Id).FirstOrDefault();

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
