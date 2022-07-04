using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Task in Lesson 1:
             İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

                Menu:
                1 - Element elave et
                2 - Elementleri goster
                3 - Element axtar
                4 - Element editle
                5 - Element sil
                6 - Exit
                Emeliyyat novunu secin:

                Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
                1:
                Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
                Daxil edəndən sonra: "Element elave olundu!"

                2:
                Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
                1. Element = 15
                2. Element = Salam
                3. Element = Hi
                Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

                3:
                Bunu seçəndə aşağıdakı yazı çıxacaq.
                "Axtarmaq istediyiniz elementi daxil edin: "
                Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
                "Element tapildi : Index :0 - Deyer: Salam"
                tapılmayıbsa bu yazı çıxsın
                "Axtardiginiz element tapilmadi".

                4:
                "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
                ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
                "Axtardiginiz element tapilmadi"
                Varsa:
                "Editlemek istediyiniz elementi daxil edin : "
                Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

                5:
                İlk öncə bunu soruşsun:
                "Butun elementleri silmek isteyirsiniz? (H/Y)"
                əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
                əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
                ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
                çıxsın.
             */
            ArrayList ArrList = new ArrayList();
            bool b = true;
            while (b)
            {

                Console.WriteLine("Menu:\n" +
                                "1 - Element elave et\n" +
                                "2 - Elementleri goster\n" +
                                "3 - Element axtar\n" +
                                "4 - Element editle\n" +
                                "5 - Element sil\n" +
                                "6 - Exit\n" +
                                "Emeliyyat novunu secin: ");

                byte operation = Convert.ToByte(Console.ReadLine());
                if (operation == 1)
                {
                    Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin:");
                    var elem = Console.ReadLine();
                    ArrList.Add(elem);

                    Console.WriteLine("Element daxil olundu");
                    Thread.Sleep(1000);

                }
                else if (operation == 2)
                {
                    int i = 1;
                    foreach (var item in ArrList)
                    {

                        Console.WriteLine(i + ". Element = " + item);
                        i++;
                    }
                    Thread.Sleep(1000);
                    Console.WriteLine("Burdan cixmaq ucun de davam etmek ucun Enter'e basin");

                    Console.ReadLine();
                }
                else if (operation == 3)
                {
                    Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin: ");
                    var wanted = Console.ReadLine();
                    if (ArrList.Contains(wanted))
                    {
                        int index = ArrList.IndexOf(wanted);
                        Console.WriteLine("Element tapildi:  " + "Index:" + index + "  Deyeri:" + wanted);
                    }
                    else
                    {
                        Console.WriteLine("Axtardiginiz element tapilmadi.");
                    }
                    Thread.Sleep(1000);
                }
                else if (operation == 4)
                {
                    Console.WriteLine("Editlemek istediyiniz elementi daxil edin: ");
                    var edit = Console.ReadLine();
                    if (ArrList.Contains(edit))
                    {

                        int ind = ArrList.IndexOf(edit);
                        ArrList.RemoveAt(ind);

                        Console.WriteLine("Ne ile evez edeceksiniz?:");
                        var edited = Console.ReadLine();

                        ArrList.Insert(ind, edited);
                        Console.WriteLine("Element editlendi");
                    }
                    else
                    {
                        Console.WriteLine("Axtardiginiz element tapilmadi");
                    }
                    Thread.Sleep(1000);
                }
                else if (operation == 5)
                {
                    Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
                    char answr = Convert.ToChar(Console.ReadLine());
                    if (answr == 'H')
                    {
                        ArrList.Clear();
                        ArrList.TrimToSize();
                        Console.WriteLine("Elementler silindi");
                    }
                    else if (answr == 'Y')
                    {
                        Console.WriteLine("Silmek istediyiniz elementi daxil edin: ");
                        var delete = Console.ReadLine();
                        if (ArrList.Contains(delete))
                        {
                            ArrList.Remove(delete);
                            Console.WriteLine(delete + " elementi silindi");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediyiniz element tapilmadi!");
                        }
                    }
                    Thread.Sleep(1000);
                }
                else if (operation == 6)
                {
                    b = false;
                    Console.WriteLine("Program bitdi.");
                }


            }

            Console.ReadLine();
        }
    }
}
