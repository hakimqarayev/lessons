using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Homework 2:
               Bir Car class'ınız olsun. (Property'ləri: Şəhər(satıldığı), Marka, Model, Buraxılış ili, Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı, Sürətlər Qutusunun tipi, Qiyməti).
               Bir list'in içinə bir neçə dənə Car əlavə edib nümunədən aşağıdakı sorğuları yazacaqsınız.
               Nümunə data:
               Şəhər: Bakı
               Marka: Lexus
               Model: GX460
               Buraxılış ili: 2021
               Rəngi: Black(Enum olacaq və 10-15 dənə rəng olsun Enum'da)
               Mühərrik Həcmi: 4500
               At Gücü: 296
               Kilometrajı: 15777
               Sürətlər Qutusunun tipi: Automatic (Enum olacaq. Dəyərləri də Automatic, Manual, Robot)
               Qiyməti: 200.000

               Aşağıdakı sorğuları yazın:
               1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
               2. Bakıda satılmayan, buraxılış ili 2015-ci il daxil olmaqla 2020-ci ilə qədər olan(2020 də daxildir buna)
               3. Kilometrajı 0 olan və Modelində "ml" sözü olan
               4. Sürətlər qutusu avtomatik olan və qiyməti 15.000-17.500 arasında olan
               5. Rəngi Red, Black olmayan, mühərrik həcmi 2000-4000 arasında olan, sürətlər qutusu Robot olmayan, buraxılış ili 2010-dan köhnə olmayan.
               6. Ya markası Lexus olub, qiyməti 30.000-ə qədər olan ya da markası Mercedes olub qiyməti 45.000-ə qədər olan.
               */
            List<Car> cars = new List<Car>()
            {
                 new Car{
                    City = "Baku",
                    Marka = "Mercedes",
                    Model = "ML 350",
                    Year = 2022,
                    GetColor = Enums.Color.Gray,
                    EngineCpacity = 3500,
                    Km = 0,
                    GetGearbox = Enums.Gearbox.Automatic,
                    Price = 50000
                },
                new Car{
                    City = "Baku",
                    Marka = "Lexus",
                    Model = "GX460",
                    Year = 2021,
                    GetColor = Enums.Color.Gray,
                    EngineCpacity = 4500,
                    Km = 15777,
                    GetGearbox = Enums.Gearbox.Automatic,
                    Price = 200000
                },

                new Car{
                    City = "Berlin",
                    Marka = "Mercedes",
                    Model = "S400",
                    Year = 2015,
                    GetColor = Enums.Color.Black,
                    EngineCpacity = 3000,
                    Km = 78000,
                    GetGearbox = Enums.Gearbox.Automatic,
                    Price = 66999
                },

                new Car{
                    City ="London",
                    Marka = "Toyota",
                    Model = "Land Cruiser",
                    Year = 2018,
                    GetColor = Enums.Color.Red,
                    EngineCpacity = 4000,
                    Km = 8000,
                    GetGearbox = Enums.Gearbox.Automatic,
                    Price = 75000
                },

                new Car{
                    City ="Baku",
                    Marka = "Tesla",
                    Model = "Model 3",
                    Year = 2021,
                    GetColor = Enums.Color.White,
                    EngineCpacity = 3000,
                    Km = 8400,
                    GetGearbox = Enums.Gearbox.Robot,
                    Price = 49800
                },
                new Car{
                       City ="Barcelona",
                    Marka = "BMW",
                    Model = "740",
                    Year = 2018,
                    GetColor = Enums.Color.Silver,
                    EngineCpacity = 3000,
                    Km = 86000,
                    GetGearbox = Enums.Gearbox.Automatic,
                    Price = 12500
                }

            };

            var query1 = cars.Find(m => m.Marka == "Mercedes" && m.EngineCpacity <= 4200 && m.City == "Baku");

            var query2 = cars.Where(m => m.City != "Baku" && m.Year <= 2020 && m.Year >= 2015).ToList();

            var query3 = cars.Where(m => m.Km == 0 && m.Model.ToLower().Contains("ml")).ToList();

            var query4 = cars.Where(m =>
                                    m.GetGearbox == Enums.Gearbox.Automatic
                                    && m.Price > 15000 &&
                                    m.Price < 17500)
                                    .ToList();

            var query5 = cars.Where(m =>
                                    m.GetColor != Enums.Color.Red &&
                                    m.GetColor != Enums.Color.Black &&
                                    m.EngineCpacity > 2000 &&
                                    m.EngineCpacity < 4000 &&
                                    m.GetGearbox != Enums.Gearbox.Robot &&
                                    m.Year > 2010)
                                    .ToList();

           // 6.Ya markası Lexus olub, qiyməti 30.000 - ə qədər olan ya da markası Mercedes olub qiyməti 45.000 - ə qədər olan.
            var query6 = cars.Where(m =>
                                    m.Marka == "Lexus" &&
                                    m.Price < 30000 ||
                                    m.Marka == "Mercedes" &&
                                    m.Price < 45000)
                                    .ToList();
            Console.ReadLine();
        }
    }
}
