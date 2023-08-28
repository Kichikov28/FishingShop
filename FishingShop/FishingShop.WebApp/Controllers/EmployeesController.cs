using FishingShop.Services;
using FishingShop.ViewModel.Employees;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FishingShop.WebApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeService employeeService;

        public EmployeesController()
        {
            this.employeeService = new EmployeeService();
        }

        public IActionResult Index(int page = 1)
        {
            EmployeesIndexViewModel models=new EmployeesIndexViewModel();
            models.PageNumber= page;
            models = employeeService.GetEmployees(models);
            return View(models);
        }
        public IActionResult LowestPaid()
        {
            List<EmployeeIndexViewModel> model = employeeService.GetLowestPaidEmployees();
            return View(model);
        }

        public IActionResult HighestPaid()
        {
            List<EmployeeIndexViewModel> model = employeeService.GetHighestPaidEmployees();
            return View(model);
        }
    }
}
