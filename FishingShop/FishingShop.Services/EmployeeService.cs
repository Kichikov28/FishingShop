namespace FishingShop.Services
{
    using FishingShop.Data;
    using FishingShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class EmployeeService
    {
        private AppDbContext context;
        public string HireEmployee(string firstName, string lastName, int age, string position, decimal salary, string contactPhone)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(firstName))
            {
                message.AppendLine($"Invalid {nameof(firstName)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                message.AppendLine($"Invalid {nameof(lastName)}!");
                isValid = false;
            }
            if (age<=0)
            {
                message.AppendLine($"Invalid {nameof(age)}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(position))
            {
                message.AppendLine($"Invalid {nameof(position)}!");
                isValid = false;
            }
            if (salary<=0) 
            {
                message.AppendLine($"Invalid {nameof(salary)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(contactPhone))
            {
                message.AppendLine($"Invalid {nameof(contactPhone)}");
                isValid = false;
            }
            if (isValid)
            {
                using (context = new AppDbContext())
                {
                    var shop = context.Shops.FirstOrDefault();
                    if (shop != null)
                    {
                        Employee employee = new Employee()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            Position = position,
                            Salary = salary,
                            ContactPhone = contactPhone,
                            ShopId = shop.Id
                        };
                        context.Employees.Add(employee);
                        context.SaveChanges();
                        message.AppendLine($"Employee {firstName} {lastName} is hired at shop {shop.Name}!");
                    }
                    else
                    {
                        message.AppendLine($"No shop found to hire the employee!");
                    }
                }
            }
            return message.ToString().TrimEnd();

        }
        public Employee GetEmployeeById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Employees.FirstOrDefault(x => x.Id==id);
            }
        }
        public string DeleteEmployeeById(int id)
        {
            using (context = new AppDbContext())
            {
                Employee employee = this.context.Employees.FirstOrDefault(x => x.Id == id);
                if (employee == null)
                {
                    return $"{nameof(Employee)} not found!";
                }
                context.Employees.Remove(employee);
                context.SaveChanges();
                return $"{nameof(Employee)} {employee.FirstName} {employee.LastName} has been fired...";
            }
        }
        public string GetEmployeeInfo(int id)
        {
            Employee employee = null;
            using (context = new AppDbContext())
            {
                employee = context.Employees.Find(id);
            }
            if (employee != null)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine($"Employee info: ");
                message.AppendLine($"\tId: {employee.Id}");
                message.AppendLine($"\tFirst name: {employee.FirstName}");
                message.AppendLine($"\tLast name: {employee.LastName}");
                message.AppendLine($"\tAge: {employee.Age}");
                message.AppendLine($"\tPosition: {employee.Position}");
                message.AppendLine($"\tSalary: {employee.Salary}");
                message.AppendLine($"\tContactPhone: {employee.ContactPhone}");
                return message.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Employee)} not found!";
            }
        }
        public string UpdateEmployeeSalary(int id, decimal salary)
        {
            using (context = new AppDbContext())
            {
                Employee employee = context.Employees.Find(id);
                if (employee == null)
                {
                    return $"Employee not found!";
                }
                employee.Salary = salary;
                context.Employees.Update(employee);
                context.SaveChanges();
                return $"Employee {employee.FirstName} {employee.LastName}'s new salary is: {salary}";
            }
        }
        public string GetAllEmployeesInfo(int page = 1, int count = 10)
        {
            StringBuilder message = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Age",-5} | {"Position",-15} | {"Salary",-10} | {"ContactPhone",-20} |";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Employee> employees = context.Employees.Skip((page - 1) * count).Take(count).ToList();
                message.AppendLine(firstRow);
                message.AppendLine(line);
                foreach (var e in employees)
                {
                    string info = $"| {e.Id,-4} | {e.FirstName,-12} | {e.LastName,-12} | {e.Age,-5} | {e.Position,-15} | {e.Salary,-10} | {e.ContactPhone,-20} |";
                    message.AppendLine(info);
                    message.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Employees.Count() / (decimal)count);
                message.AppendLine($"Page: {page} / {pageCount}");
            }

            return message.ToString().TrimEnd();
        }
        public int GetEmployeePagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Employees.Count() / (double)count);
            }
        }
        public List<string> GetEmployeesBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Employees
                    .Skip((page - 1) * count)
                    .Take(count)
                    .Select(x => $"{x.Id} - {x.FirstName} {x.LastName} is {x.Age}")
                    .ToList();
            }
            return list;
        }
    }
}
