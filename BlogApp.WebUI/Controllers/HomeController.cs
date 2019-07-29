using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagement.Data.Abstract;
using ProjectManagement.Data.Concrete.EFCore;
using ProjectManagement.Entity;
using ProjectManagement.Entity.Enums;

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private ISampleRepository sampleRepository;
        private IEmployeeRepository employeeRepository;

        public HomeController(ISampleRepository sampleRepo, IEmployeeRepository _employeeRepo)
        {
            sampleRepository = sampleRepo;
            employeeRepository = _employeeRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var sample=sampleRepository.GetById(id);
            ViewBag.Employees = new SelectList(employeeRepository.GetAll(), "EmployeeId", "Name");
            ViewBag.States = new SelectList(Enum.GetNames(typeof(State)));
            return View(sample);
        }

        public IActionResult Delete(int id)
        {
            sampleRepository.deleteSample(id);
            var samples = sampleRepository.GetAll();
            TempData["alertClass"] = "danger";
            TempData["alertMessage"] = id+" numaralı kayıt silindi.";

            //employelist'i view'a taşımank için
            IQueryable<Employee> list = employeeRepository.GetAll();
            ViewBag.employeeList = list;


            return View("List",samples);
        }

        [HttpPost]
        public async Task<IActionResult> Details(Sample sample, IFormFile sampleImg, IFormFile addFile)
        {

            ViewBag.Employees = new SelectList(employeeRepository.GetAll(), "EmployeeId", "Name");
            ViewBag.States = new SelectList(Enum.GetNames(typeof(State)));

            if (ModelState.IsValid)
            {
                if (sampleImg != null)
                {
                    //image path
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", sampleImg.FileName);

                    //image saving path
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await sampleImg.CopyToAsync(stream);
                    }

                    //image file name adding entity
                    sample.Image = sampleImg.FileName;
                }
                if (addFile != null)
                {
                    //image path
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", addFile.FileName);

                    //image saving path
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await addFile.CopyToAsync(stream);
                    }

                    //image file name adding entity
                    sample.AdditionalFile = addFile.FileName;
                }



                sampleRepository.updateSample(sample);
                TempData["alertClass"] = "success";
                TempData["alertMessage"] = sample.SampleId + " numaralı kayıt güncellendi.";
                return View(sample);
            }
            else
            {
                TempData["alertClass"] = "danger";
                TempData["alertMessage"] = "Hata oluştu.";
                
                return View(sample);
            }
        }

        public IActionResult Create()
        {
            ViewBag.Employees = new SelectList(employeeRepository.GetAll(), "EmployeeId", "Name");
            ViewBag.States = new SelectList(Enum.GetNames(typeof(State)));
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Sample sample, IFormFile file)
        {
            ViewBag.Employees = new SelectList(employeeRepository.GetAll(), "EmployeeId", "Name");
            ViewBag.States = new SelectList(Enum.GetNames(typeof(State)));

            if (ModelState.IsValid)
            {

                if (file !=null)
                {
                    //image path
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);

                    //image saving path
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    //image file name adding entity
                    sample.Image = file.FileName;
                }
    

                //entity saving
                Sample sampleOk = sampleRepository.addSample(sample);


                if (sampleOk != null)
                {
                    TempData["alertClass"] = "success";
                    TempData["alertMessage"] = sampleOk.SampleId + " numaralı kayıt eklendi.";
                    return View("Details", sampleOk);
                }
                else
                {
                    TempData["alertClass"] = "danger";
                    TempData["alertMessage"] = "Hata oluştu.";
                    return View(sample);
                }

                
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                TempData["alertClass"] = "danger";
                TempData["alertMessage"] = "Hata oluştu.";
                return View(sample);
            }

        }



        public IActionResult List()
        {
            IQueryable<Employee> list = employeeRepository.GetAll();
            ViewBag.employeeList = list;
            return View(sampleRepository.GetAll());
        }
        public IActionResult Gantt()
        {
            ViewBag.Employees = new SelectList(employeeRepository.GetAll(), "EmployeeId", "Name");
            return View();
        }
    }
}