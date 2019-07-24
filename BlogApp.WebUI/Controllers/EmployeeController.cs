using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectManagement.Data.Abstract;
using ProjectManagement.Data.Concrete.EFCore;
using ProjectManagement.Entity;
using ProjectManagement.Entity.Enums;

namespace BlogApp.WebUI.Controllers
{
    public class EmployeeController : Controller
    {

        private IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository _employeeRepo)
        {
            employeeRepository = _employeeRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var sample=employeeRepository.GetById(id);
            return View(sample);
        }

        public IActionResult Delete(int id)
        {
            var employees = employeeRepository.GetAll();
            employeeRepository.DeleteEmployee(id);
            TempData["alertClass"] = "danger";
            TempData["alertMessage"] = id+" numaralı kayıt silindi.";

            return View("List",employees);
        }

        [HttpPost]
        public IActionResult Details(Employee employee)
        {

            if (ModelState.IsValid)
            {
               employeeRepository.UpdateEmployee(employee);
                TempData["alertClass"] = "success";
                TempData["alertMessage"] = employee.EmployeeId + " numaralı kayıt güncellendi.";
                return View(employee);
            }
            else
            {
                TempData["alertClass"] = "danger";
                TempData["alertMessage"] = "Hata oluştu.";
                
                return View(employee);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            if (ModelState.IsValid)
            {
                employeeRepository.AddEmployee(employee);
             
                    TempData["alertClass"] = "success";
                    TempData["alertMessage"] = employee.EmployeeId + " numaralı kayıt eklendi.";
               
             

                return View("Details", employee);
            }
            else
            {
                TempData["alertClass"] = "danger";
                TempData["alertMessage"] = "Hata oluştu.";
                return View(employee);
            }

        }



        public IActionResult List()
        {
            return View(employeeRepository.GetAll());
        }
    }
}