namespace FishingShop.ViewModel.Employees
{
    using FishingShop.ViewModel.Shared;
    using System.Collections.Generic;
    public class EmployeesIndexViewModel : PagingViewModel
    {
        public List<EmployeeIndexViewModel> Employees { get; set; }
        public EmployeesIndexViewModel()
        {
            this.Employees = new List<EmployeeIndexViewModel>();
        }
    }
}
