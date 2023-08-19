namespace FishingShop.Services
{
    using Castle.Core.Resource;
    using FishingShop.Data;
    using FishingShop.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Linq;

    public class ClientService
    {
        private AppDbContext context;
        public string AddCustomer(string firstName,string lastName,string email, string phoneNumber, string adress)
        {
            StringBuilder message= new StringBuilder();
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
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                message.AppendLine($"Invalid {nameof(phoneNumber)}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(adress))
            {
                message.AppendLine($"Invalid {nameof(adress)}!");
                isValid = false;
            }
            if (isValid)
            {
                Client client = new Client()
                {
                    FirstName = firstName,
                    LastName=lastName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Adress = adress
                };
                using (context = new AppDbContext())
                {
                    context.Clients.Add(client);
                    context.SaveChanges();
                    message.AppendLine($"Client {firstName} {lastName} is added!");
                }
            }
            return message.ToString().TrimEnd();
        }
        public Client GetClientById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Clients.FirstOrDefault(x => x.Id == id);
            }
        }
        public string DeleteClientById(int id)
        {
            using (context = new AppDbContext())
            {
                Client c = this.context.Clients.FirstOrDefault(x => x.Id == id);
                if (c == null)
                {
                    return $"{nameof(Client)} not found!";
                }
                context.Clients.Remove(c);
                context.SaveChanges();
                return $"{nameof(Client)} {c.FirstName} {c.LastName} is not our client anymore!";
            }
        }
        public List<string> GetClients()
        {
            List<string> clientsInfo;
            using (context = new AppDbContext())
            {
                clientsInfo = this.context.Clients.
                     OrderBy(x => x.Id)
                     .Select(x => $"{x.Id} - {x.FirstName} {x.LastName}")
                     .ToList();
            }
            return clientsInfo;
        }
    }
}
