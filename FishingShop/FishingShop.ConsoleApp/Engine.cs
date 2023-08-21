namespace FishingShop.ConsoleApp
{
    using FishingShop.Models;
    using FishingShop.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Engine
    {
        private OrderService orderService;
        private CatalogService catalogService;
        private ProductService productService;
        private ShopService shopService;
        private EmployeeService employeeService;
        private ClientService clientService;

        public Engine()
        {
            orderService=new OrderService();
            catalogService=new CatalogService();
            productService=new ProductService();
            shopService=new ShopService();
            employeeService=new EmployeeService();
            clientService=new ClientService();
            Run();
        }
        public void Run()
        {
            Console.WriteLine("Welcome to the AquaLure's App!");
            while (true)
            {
                try
                {
                    Console.Clear();
                    Menu();
                    Console.Write("Enter your choice: ");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "0":
                            return;
                        case "1":
                            GetShopById();
                            break;
                        case "2":
                            AddShop();
                            break;
                        case "3":
                            AllShopsInfo();
                            break;
                        case "4":
                            AddProduct();
                            break;
                        case "5":
                            UpdateProductPrice();
                            break;
                        case "6":
                            CreateOrder();
                            break;
                        case "7":
                            AllProductsInfo();
                            break;
                        case "8":
                            HireEmployee();
                            break;
                        case "9":
                            UpdateEmployeeSalary();
                            break;
                        case "10":
                            GetEmployeeByID();
                            break;
                        case "11":
                            DeleteEmployeeByID();
                            break;
                        case "12":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input! Please try again.");
                            PressKey();
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    PressKey();
                }
            }
        }
        private void UpdateEmployeeSalary()
        {
            Console.Write("Enter employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());
            Console.Write("Enter new salary: ");
            decimal newSalary = decimal.Parse(Console.ReadLine());
            string result = employeeService.UpdateEmployeeSalary(employeeId, newSalary);
            Console.WriteLine(result);
            PressKey();
        }

        private void GetEmployeeByID()
        {
            Console.Write("Enter employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());
            Employee employee = employeeService.GetEmployeeById(employeeId);
            if (employee != null)
            {
                Console.WriteLine($"Employee with ID {employee.Id} - {employee.FirstName} {employee.LastName}");
            }
            else
            {
                Console.WriteLine($"Employee with ID {employeeId} not found.");
            }
            PressKey();
        }
        private void DeleteEmployeeByID()
        {
            Console.Write("Enter employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());
            string result = employeeService.DeleteEmployeeById(employeeId);
            Console.WriteLine(result);
            PressKey();
        }
        private void HireEmployee()
        {
            Console.Write("Enter employee first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter employee last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter employee age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter employee position: ");
            string position = Console.ReadLine();
            Console.Write("Enter employee salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter employee contact phone: ");
            string contactPhone = Console.ReadLine();
            string result = employeeService.HireEmployee(firstName, lastName, age, position, salary, contactPhone);
            Console.WriteLine(result);
            PressKey();
        }

        private void AllProductsInfo()
        {
            int currentPage = 1;
            int pageCount = productService.GetProductsPagesCount();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Products list: ");
                string info = productService.GetAllProductsInfo(currentPage);
                Console.WriteLine(info);
                Console.WriteLine($"Page: {currentPage} / {pageCount}");
                Console.WriteLine("Commands: 0:Back, 1:Previous page, 2:Next page ");
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        if (currentPage > 1) { currentPage--; }
                        break;
                    case "2":
                        if (currentPage < pageCount) { currentPage++; }
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please select a valid option.");
                        break;
                }
            }
        }
        private void CreateOrder()
        {
            Console.Write("Enter shop Id in the range 1-50: ");
            int shopId = int.Parse(Console.ReadLine());
            Console.Write("Enter client id int the range 1-20: ");
            int clientId = int.Parse(Console.ReadLine());
            Console.Write("Enter item id's in the range 1-80 separated by interval: ");
            List<int> products = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Console.WriteLine(orderService.CreateOrder(shopId, clientId, products));
            PressKey();
        }
        private void UpdateProductPrice()
        {
            Console.Write("Enter product ID: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Enter new price: ");
            decimal newPrice = decimal.Parse(Console.ReadLine());
            string result = productService.UpdateProductPrice(productId, newPrice);
            Console.WriteLine(result);
            PressKey();
        }
        private void AddProduct()
        {
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter product price: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());
            string result = productService.AddProduct(productName, productPrice);
            Console.WriteLine(result);
            PressKey();
        }

        private void AllShopsInfo()
        {
            int currentPage = 1;
            int pageCount = shopService.GetShopsPagesCount();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Shops list: ");
                string info = shopService.GetAllShopsInfo(currentPage);
                Console.WriteLine(info);
                Console.WriteLine($"Page: {currentPage} / {pageCount}");
                Console.WriteLine("Commands: 0:Back, 1:Previous page, 2:Next page ");
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        if (currentPage > 1) { currentPage--; }
                        break;
                    case "2":
                        if (currentPage < pageCount) { currentPage++; }
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please select a valid option.");
                        break;
                }
            }
        }
        private void AddShop()
        {
            Console.Write("Enter shop name: ");
            string shopName = Console.ReadLine();
            Console.Write("Enter shop location: ");
            string shopLocation = Console.ReadLine();
            Console.Write("Enter shop type: ");
            string shopType = Console.ReadLine();
            Console.Write("Enter shop rating: ");
            double shopRating = double.Parse(Console.ReadLine());
            string result = shopService.AddShop(shopName, shopLocation, shopType, shopRating);
            Console.WriteLine(result);
            PressKey();
        }
        private void GetShopById()
        {
            Console.Write("Enter shop ID: ");
            int itemID = int.Parse(Console.ReadLine());
            var shop = shopService.GetShopById(itemID);
            Console.WriteLine($"Shop with this id is {shop.Name} and is located in {shop.Location}.");
            PressKey();
        }
        private static void PressKey()
        {
            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();
        }
        public void Menu()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine($"Menu:");
            message.AppendLine($"\t0: Back");
            message.AppendLine($"\t1: Get Shop by ID");
            message.AppendLine($"\t2: Add Shop");
            message.AppendLine($"\t3: Get All Shops Info");
            message.AppendLine($"\t4: Add Product  ");
            message.AppendLine($"\t5: Update Product Price");
            message.AppendLine($"\t6: Create Order");
            message.AppendLine($"\t7: Get All Products Info");
            message.AppendLine($"\t8: Hire Employee");
            message.AppendLine($"\t9: Update Employee Salary");
            message.AppendLine($"\t10: Get Employee By ID");
            message.AppendLine($"\t11: Delete Employee By ID");
            message.AppendLine($"\t12: Exit");
            Console.WriteLine(message.ToString().TrimEnd());
        }
    }
}
