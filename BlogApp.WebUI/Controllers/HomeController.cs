using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data.Abstract;
using ProjectManagement.Data.Concrete.EFCore;

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

        public IActionResult Details()
        {
            return View();
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