using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data.Abstract;
using ProjectManagement.Data.Concrete.EFCore;
using ProjectManagement.Entity;

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private ISampleRepository sampleRepository;

        public HomeController(ISampleRepository sampleRepo)
        {
            sampleRepository = sampleRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var sample=sampleRepository.GetById(id);

            return View(sample);
        }

        public IActionResult Delete(int id)
        {
            sampleRepository.deleteSample(id);
            var samples = sampleRepository.GetAll();
            TempData["alertClass"] = "danger";
            TempData["alertMessage"] = id+" numaralı kayıt silindi.";

            return View("List",samples);
        }

        [HttpPost]
        public IActionResult Details(Sample sample)
        {
            sampleRepository.updateSample(sample);
            TempData["alertClass"] = "success";
            TempData["alertMessage"] = sample.SampleId + " numaralı kayıt güncellendi.";
            return RedirectToAction("Details",sample.SampleId);
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Sample sample)
        {
            Sample sampleOk=sampleRepository.addSample(sample);
            if (sampleOk !=null)
            {
                TempData["alertClass"] = "success";
                TempData["alertMessage"] = sampleOk.SampleId + " numaralı kayıt eklendi.";
            }
            else
            {
                TempData["alertClass"] = "danger";
                TempData["alertMessage"] = "Hata oluştu.";
            }

            return View(sampleOk);
        }



        public IActionResult List()
        {

            return View(sampleRepository.GetAll());
        }
        public IActionResult Gantt()
        {
            return View();
        }
    }
}