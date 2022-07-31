using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        public Contact[] Contacts;
        public Address[] Addresses;
        public Order[] Orders;

        public Customer()
        {
            Contacts = new Contact[100];
            Addresses = new Address[100];
            Orders = new Order[100];
        }
        public void ShowOrders()
        {
            int a = 1;

            for (int i = 0; i < Orders.Length; i++)
            {
                if (Orders[i] != null)
                {
                    Console.WriteLine(a + "." + "Order ID: " + Orders[i].ID);
                    Console.WriteLine(a + "." + "Order Creation Date: " + Orders[i].CreateTime);
                    Console.WriteLine(a + "." + "Shipping Address of the Order: " + Orders[i].ShippingAddress);
                    Console.WriteLine(a + "." + "Shipping Info: " + Orders[i].InfoOrder);
                    Console.WriteLine();
                }
                else
                    break;
                a++;
            }
        }

        public void ShowContact()
        {
            int a = 1;
            for (int i = 0; i < Contacts.Length; i++)
            {
                if (Contacts[i] != null)
                {
                    Console.WriteLine(a + "" + "Contact ID: " + Contacts[i].ID);
                    Console.WriteLine(a + "." + "Contact Number: " + Contacts[i].PhoneNumber);
                    Console.WriteLine(a + "." + "Contact Email: " + Contacts[i].Email);
                    Console.WriteLine(a + "." + "Contact CreateDate: " + Contacts[i].CreateDate);
                    if (EditDate !=null)
                        Console.WriteLine(a + "." + "Editdate: " + Contacts[i].EditDate.Value.ToString("dd.MM.yyyy"));
                    else
                        Console.WriteLine("Data is not edited");
                    Console.WriteLine();
                }
                else
                    break;
                a++;
            }
        }

        public void ShowAddress()
        {
            for (int i = 0; i < Addresses.Length; i++)
            {
                int a = 1;

                if (Addresses[i] != null)
                {
                    Console.WriteLine(a + "." + "Address ID: " + Addresses[i].Id);
                    Console.WriteLine(a + "." + "Address No: " + Addresses[i].No);
                    Console.WriteLine(a + "." + "Street Address: " + Addresses[i].Street);
                    Console.WriteLine(a + "." + "Date of Creation of the Address" + Addresses[i].CreateDate);
                    Console.WriteLine(a + "." + "Distinct: " + Addresses[i].Distinct);
                    Console.WriteLine(a + "." + "Building: " + Addresses[i].Building);
                    Console.WriteLine(a + "." + "City ID: " + Addresses[i].City.Id);
                    Console.WriteLine(a + "." + "City Name: " + Addresses[i].City.Name);
                    Console.WriteLine();
                }
                else
                    break;
                a++;

            }
        }

        public void ShowAll()
        {
            ShowAddress();
            ShowContact();
            ShowOrders();
        }
    }
}
