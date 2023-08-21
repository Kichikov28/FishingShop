namespace FishingShop.Seeder
{
    using FishingShop.Services;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static ClientService clientService = new ClientService();
        public static ShopService shopService = new ShopService();
        public static ProductService productService = new ProductService();
        public static CatalogService catalogService = new CatalogService();
        public static EmployeeService employeeService = new EmployeeService();
        public static void Main()
        {
            SeedShops();
            SeedCatalogs();
            SeedProducts();
            SeedClients();
            SeedEmployees();
        }
        public static void SeedShops()
        {
            List<string> name = new List<string>() { "Reel Catch Fishing Gear", "Angler's Haven Outfitters", "Fisherman's Depot", "Tackle Haven", "Fin & Feather Fishing Shop", "FishCraft Outdoors", "Reel Adventure Angling", "BaySide Bait & Tackle", "Saltwater Soul Fishing Gear", "AquaHub", "TideBay", "CastWave", "FishLink", "HookScape", "LureLife", "ReelMasters", "FinFusion", "LineLuxe", "FinRipple", "RodHarbor", "FinNook", "CastCharm" };
            List<string> location = new List<string>() { "Velingrad", "Sofia", "Plovdiv", "Varna", "Burgas", "Veliko Tarnovo", "Haskovo", "Ruse", "Stara Zagora", "Vidin", "Pazardjik", "Tasos", "Boston", "New York", "Maine", "Paris", "Madrid", "Berlin", "Vienna", "Sozopol", "Blagoevgrad", "Watertown", "Plymouth", "Barnstable", "New Bedford", "Stamford", "Norwalk", "Camden", "Rockland", "Bristol", "Helsinki", "Turku", "Oslo", "Tallin" };
            List<string> type = new List<string>() { "saltwater", "sweetwater" };
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                int fishingshopName = random.Next(0, name.Count);
                int fishingshopLocation = random.Next(0, location.Count);
                double rating = Math.Round(random.NextDouble() * 8 + 2, 1);
                int fishingshopType = random.Next(0, type.Count);
                Console.WriteLine($"{shopService.AddShop(name[fishingshopName], location[fishingshopLocation], type[fishingshopType], rating)}");
            }
        }
        public static void SeedCatalogs()
        {
            List<string> type = new List<string> { "Saltwater", "Sweetwater" };
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                int catalogType = random.Next(0, type.Count);
                int fishingshopId = random.Next(1, 50);
                Console.WriteLine(catalogService.CreateCatalog(type[catalogType], fishingshopId));
            }
        }
        public static void SeedProducts()
        {
            List<string> name = new List<string>() { "Fishing rod", "Minnow", "Spinner", "Fishing Bibs", "Fishing float", "Fishing reel", "Hooks", "Flies", "Fishing Net", "Tackle box", "Fishing line", "Bag", "Multitool", "Jig heads" };
            Random random = new Random();
            for (int i = 0; i < 80; i++)
            {
                int productName = random.Next(0, name.Count);
                decimal price = (decimal)Math.Round(random.NextDouble() * random.Next(20, 30), 2);
                Console.WriteLine(productService.AddProduct(name[productName], price));
            }
        }
        public static void SeedClients()
        {
            Console.WriteLine(clientService.AddClient("Ivan", "Petrov", "ivanp@gmail.com", "0899123456", "Sofia Street 10"));
            Console.WriteLine(clientService.AddClient("Maria", "Ivanova", "marii@abv.bg", "0888234567", "Vitosha Blvd 25"));
            Console.WriteLine(clientService.AddClient("Georgi", "Stoyanov", "georgist@gmail.com", "0877345678", "Plovdiv Street 5"));
            Console.WriteLine(clientService.AddClient("Elena", "Georgieva", "elenag@abv.bg", "0896456789", "Tsarigradsko Shosse Blvd 15"));
            Console.WriteLine(clientService.AddClient("Dimitar", "Angelov", "dimitara@mail.bg", "0885567890", "Rilska Street 2"));
            Console.WriteLine(clientService.AddClient("Svetla", "Dimitrova", "svetlad@mail.bg", "0874678901", "Balchik Street 7"));
            Console.WriteLine(clientService.AddClient("Nikolay", "Slavov", "nikolais@gmail.com", "0893789012", "Slivnishko Shosse Blvd 12"));
            Console.WriteLine(clientService.AddClient("Anna", "Nikolova", "annan@gmail.com", "0882890123", "Shumen Street 8"));
            Console.WriteLine(clientService.AddClient("Peter", "Kirov", "petark@gmail.com", "0871901234", "Osmi Primorski Polk Blvd 20"));
            Console.WriteLine(clientService.AddClient("Lilia", "Petkova", "liliyap@gmail.com", "0890012345", "Dobrudzhanska Street 3"));
            Console.WriteLine(clientService.AddClient("Stefan", "Stoychev", "stefan@gmail.com", "0888111222", "Bulgaria Blvd 5"));
            Console.WriteLine(clientService.AddClient("Marta", "Dimitrova", "marta@mail.bg", "0877333444", "Varna Street 12"));
            Console.WriteLine(clientService.AddClient("Viktor", "Ivanov", "viktor@gmail.com", "0899555666", "Sofia Street 15"));
            Console.WriteLine(clientService.AddClient("Nina", "Petrova", "nina@gmail.com", "0888777888", "Plovdiv Street 8"));
            Console.WriteLine(clientService.AddClient("Kalina", "Georgieva", "kalina@abv.bg", "0899444555", "Burgas Street 7"));
            Console.WriteLine(clientService.AddClient("Martin", "Kostov", "martin@abv.bg", "0877666777", "Vitosha Blvd 20"));
            Console.WriteLine(clientService.AddClient("Iva", "Andreeva", "iva@gmail.com", "0888333444", "Ruse Street 3"));
            Console.WriteLine(clientService.AddClient("Stoyan", "Pavlov", "stoyan@abv.bg", "0899888777", "Pleven Street 10"));
            Console.WriteLine(clientService.AddClient("Diana", "Todorova", "diana@gmail.com", "0877555333", "Svishtov Street 6"));
            Console.WriteLine(clientService.AddClient("Dimitri", "Iliev", "dimitri@abv.bg", "0888111555", "Sofia Street 25"));
        }
        public static void SeedEmployees()
        {
            List<string> firstName = new List<string>() { "Ivaylo", "Petyr", "Viktor", "Stefan", "Ivan", "Anton", "Daniel", "Marin", "Tihomir", "Vasil", "Mario", "Lorenco" };
            List<string> lastName = new List<string>() { "Ivanov", "Petrov", "Gospodinov", "Georgiev", "Gagov", "Maladinov", "Nikolov", "Dimitrov", "Stoyanov", "Pavlov", "Kostov", "Todorov" };
            List<string> position = new List<string>() { "Sales Associate", "Manager" , "Cashier" , "Assistant Manager"};
            List<string> contactPhone = new List<string>() { "0891254832", "0897654892", "0872054891", "0897725192", "0897657210", "0897654828", "0897612345", "0897731897", "0897654821", "0897654842" };
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                int employeeFirstName = random.Next(0, firstName.Count);
                int employeeLastName = random.Next(0, lastName.Count);
                int age = random.Next(18, 60);
                int employeePosition= random.Next(0, position.Count);
                decimal minSalary = 1000;
                decimal maxSalary = 5000;
                decimal salary= (decimal)random.NextDouble() * (maxSalary - minSalary) + minSalary;
                int employeeContactPhone = random.Next(0, contactPhone.Count);
                Console.WriteLine(employeeService.HireEmployee(firstName[employeeFirstName], lastName[employeeLastName], age, position[employeePosition], salary, contactPhone[employeeContactPhone]));
            }
          

        }
    }
}
