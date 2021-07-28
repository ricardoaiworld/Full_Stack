using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace ClientSystemMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult NewEmployee()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Employee()
        {
            var employees = await _employeeService.GetAllEmployees();

            return View(employees);
        }

        [HttpPost]
        public async Task<IActionResult> NewEmployeeAsync(EmployeeAddRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var clientCard = await _employeeService.AddNewEmployee(model);
            return RedirectToAction("Employee", "Employee");
        }

        public async Task<IActionResult> EmployeeDetails(int id)
        {
            var employeeDetails = await _employeeService.GetEmployeeDetails(id);
            return View(employeeDetails);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(EmployeeDetailsModel model)
        {
            var updatedClientCard = await _employeeService.UpdateEmployee(model);
            return RedirectToAction("Employee", "Employee");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEmployee(EmployeeDetailsModel model)
        {
            await _employeeService.DeleteEmployee(model.Id);
            return RedirectToAction("Employee", "Employee");
        }
    }
}