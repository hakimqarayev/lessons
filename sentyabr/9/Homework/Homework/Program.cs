using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {/*
             Customer class'ının Id, Name, Surname, Age property'ləri olsun. Birdə əlavə olaraq Address Class'ı yaradıb onu da
             inner type olaraq Customer'ə property kimi əlavə edin. Address'in bu property'ləri olacaq: Id, No, Building, Street,
             City, Country. City və Country'ni Address'in içində string olaraq verin əlavə Class'a çıxarmağa ehtiyyac yoxdur.
             2-3 dənə Customer və onların Address'lərini əlavə edib sonra Customer tipində bir listə yığın. Sizdən istədiyim odur
             ki, Foreach ilə (customers.Foreach()) aşağıdakı kimi dataları yazdırasınız:
                ID: 1
                Name: Cavid
                Surname: Cavidov
                Age: 20
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country

                ID: 2
                Name: Hasan
                Surname: Hasanov
                Age: 32
                Address Info:
                ID: 100
                No: 10
                Building: Some Building
                Street: Some Street
                City: Some City
                Country: Some Country
             */
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Cavid",
                Surname = "Cavidov",
                Age = 20,
            };
            customer1.Address = new Address
            {
                Id = 100,
                No = 10,
                Building = "Residance",
                Street = "HomeStreet",
                City = "Baku",
                Country = "Azerbaijan"
            };
            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Hasan",
                Surname = "Hasanov",
                Age = 32,
            };
            customer2.Address = new Address
            {
                Id = 200,
                No = 20,
                Building = "Some Building",
                Street = "Some Street",
                City = "Berlin",
                Country = "Germany"
            };
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);


            customers.ForEach(i =>
            Console.WriteLine("-------- Customer Info -------- " + "\r\n" +
                              "Customer ID: " + i.Id + "\r\n" +
                              "Customer Name: " + i.Name + "\r\n" +
                              "Customer Surname: " + i.Surname + "\r\n" +
                              "-------- Address Info -------- " + "\r\n" +
                              "Id: " + i.Address.Id + "\r\n" +
                              "No: " + i.Address.No + "\r\n" +
                              "Building: " + i.Address.Building + "\r\n" +
                              "Street: " + i.Address.Street + "\r\n" +
                              "City: " + i.Address.City + "\r\n" +
                              "Country:" + i.Address.Country
                               ));


            Console.ReadLine();
        }
    }
}
