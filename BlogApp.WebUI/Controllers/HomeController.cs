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

        [HttpPost]
        public IActionResult Details(Sample sample)
        {
            sampleRepository.updateSample(sample);

            return RedirectToAction("Details",sample.SampleId);
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