using Hotel.Data;
using Hotel.Models.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System.IO;

namespace Hotel.Controllers
{
    [Area("Master")]
    public class MasterCustomer : Controller
    {
        private HMSContext Hms;
        private IMapper Mapper;
        string message = string.Empty;
        public MasterCustomer(HMSContext Hms,IMapper Mapper)
        {
            this.Hms = Hms;
            this.Mapper = Mapper;
        }
        public IActionResult Index(bool ? success)
        {
            IndexViewModel model = new IndexViewModel();
            model.ListCustomer = Hms.Set<TblCustomer>();
            @ViewBag.Success = success;
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateEditViewModel model = new CreateEditViewModel();

            var url = HttpContext.Request.Path;
            ViewBag.path = Path.GetFileName(url);
            model.TglLahir = DateTime.Now;
            return PartialView("CreateEdit",model);
        }

        [HttpGet]
        public IActionResult Edit(string Nik)
        {
            var url = HttpContext.Request.Path;
            ViewBag.path = Path.GetFileName(url);

            var model = new CreateEditViewModel();


            var data = Hms.Set<TblCustomer>().Where(x => x.Nik == Nik).FirstOrDefault();
            model.Nik = data.Nik;
            model.Nama = data.Nama;
            model.TempatLahir = data.TempatLahir;
            model.TglLahir = data.TglLahir;
            model.KewargaNegaraan = data.KewargaNegaraan;
            model.JenisKelamin = data.JenisKelamin;
            model.Pekerjaan = data.Pekerjaan;
            model.Alamat = data.Alamat;
            model.Agama = data.Agama;
            model.StatusPribadi = data.StatusPribadi;


            return PartialView("CreateEdit",model);
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form,CreateEditViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return Json(model);
            }

            try
            {
                var customer = new TblCustomer();
                customer.Nik = model.Nik;
                customer.Nama = model.Nama;
                customer.TempatLahir = model.TempatLahir;
                customer.TglLahir = model.TglLahir;
                customer.KewargaNegaraan = model.KewargaNegaraan;
                customer.JenisKelamin = model.JenisKelamin;
                customer.Agama = model.Agama;
                customer.Alamat = model.Alamat;
                customer.StatusPribadi = model.StatusPribadi;
                customer.Pekerjaan = model.Pekerjaan;

                Hms.Add(customer);
                Hms.SaveChanges();
                ViewBag.Success = true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(message);
            }

            return RedirectToAction("Index",new {success = true });
        }

        [HttpPost]
        public IActionResult Edit(IFormCollection form,CreateEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(model);
            }

            try
            {
                var customer = new TblCustomer();
                customer.Nik = model.Nik;
                customer.Nama = model.Nama;
                customer.TempatLahir = model.TempatLahir;
                customer.TglLahir = model.TglLahir;
                customer.KewargaNegaraan = model.KewargaNegaraan;
                customer.JenisKelamin = model.JenisKelamin;
                customer.Agama = model.Agama;
                customer.Alamat = model.Alamat;
                customer.StatusPribadi = model.StatusPribadi;
                customer.Pekerjaan = model.Pekerjaan;

                Hms.Update(customer);
                Hms.SaveChanges();
                message = "Success";
                ViewBag.Success = true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Json(message);
            }

            return RedirectToAction("Index", new { success = true });
        }

    }
}
