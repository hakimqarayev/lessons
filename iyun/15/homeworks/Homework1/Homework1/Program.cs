using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             Əvvəlcədən iki dəyişəndə username və password saxlayın. 
             Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın
             Sonra istifadəçidən username və password'u daxil etməsini istəyin. 
             Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 
             3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
             */

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            const string username = "hakimqarayev";
            const string password = "123H#";

            string enteredUsername, enteredPassword;

            Console.WriteLine("username daxil edin:");
             enteredUsername = Console.ReadLine();

            Console.WriteLine("password daxil edin:");
             enteredPassword = Console.ReadLine();

            if (username == enteredUsername && password == enteredPassword)
            {
                Console.WriteLine("Sistemə daxil olundu.");
            }
            else
            {
                Console.WriteLine("Məlumatlar yanlışdır. \nYenidən cəhd edin(*2 şansınız var)");

                Console.WriteLine("username daxil edin:");
                enteredUsername = Console.ReadLine();

                Console.WriteLine("password daxil edin:");
                enteredPassword = Console.ReadLine();

                if (username == enteredUsername && password == enteredPassword)
                {
                    Console.WriteLine("Məlumatlar duzgundur, Sistemə daxil oldunuz.");
                }
                else
                {
                    Console.WriteLine("Məlumatlar yanlışdır. \n Yenidən cəhd edin(*son ansınız qaldı)");

                    Console.WriteLine("username daxil edin:");
                    enteredUsername = Console.ReadLine();

                    Console.WriteLine("password daxil edin:");
                    enteredPassword = Console.ReadLine();

                    if (username == enteredUsername && password == enteredPassword)
                    {
                        Console.WriteLine("Məlumatlar duzgundur, Sistemə daxil oldunuz.");
                    }
                    else
                    {
                        Console.WriteLine("Hesabınız bloklandı.");
                    }
                }
            }
            
            

            Console.ReadLine();

        }
    }
}
