using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Item
    {
        public string Brand;
        public string Model;
        public int DateOfProduction;
        public int Mileage;
        public string TypeOfFuel;
        public string Gearbox;
        public double PurchasePrice;
        public double SalePrice;
        public double DiscountPrice;
        private double Price;

        public Item(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Item(string brand, string model, int dateOfProduction)
        {
            Brand = brand;
            Model = model;
            DateOfProduction = dateOfProduction;
        }

        public Item(string brand, string model, int dateOfProduction, int mileage)
        {
            Brand = brand;
            Model = model;
            DateOfProduction = dateOfProduction;
            Mileage = mileage;
        }

        public Item(string brand, string model, int dateOfProduction, int mileage, string typeOfFuel, string gearbox, 
            double purchasePrice, double salePrice, double discountPrice, double price)
        {
            Brand = brand;
            Model = model;
            DateOfProduction = dateOfProduction;
            Mileage = mileage;
            TypeOfFuel = typeOfFuel;
            Gearbox = gearbox;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            DiscountPrice = discountPrice;
            Price = price;
        }
        public string Info()
        {
            return string.Format(" Brand= {0}\n Model= {1}\n DateOfPrudction= {2}\n Mileage= {3}\n" +
                " TypeOfFuel= {4}\n Gearbox= {5}\n PurchasePrice= {6}\n SalePrice= {7}\n DiscountPrice= {8}\n Price= {9}"
                ,Brand, Model, DateOfProduction, Mileage, TypeOfFuel, Gearbox, PurchasePrice, SalePrice, DiscountPrice, Price);
        }

        public void SetPrice(double _price)
        {
            double calcMinPrice = SalePrice - DiscountPrice;

            if(Price < calcMinPrice)
                Console.WriteLine("Price can't update!");
            else
                Console.WriteLine("Price updated!");
        }
        

        internal void CheckCustomerFromDb()
        {

        }

    }
}
