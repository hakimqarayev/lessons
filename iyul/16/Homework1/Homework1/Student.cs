using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Student
    {
        private string _name;
        private string _surname;
        private string _email;

        public string Name
        {
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    bool check = char.IsLetter(value[i]);

                    if (check)
                        this._name = value;
                    else
                        Console.WriteLine("Ad daxil edilerken yalniz herflerden istifade edin!");
                }



                /*    ilk defe name set olunanda burdaki if blokuna girmeyecek. Sebeb ise surname field'inin null olmasidir, 
                  eger ki, once Surname, sonra Name set edilse o zaman buradaki
                  if blokuna girib email fieldine deyerini set edecek.
                 */
                if (!(string.IsNullOrEmpty(_surname)) && !(string.IsNullOrWhiteSpace(_surname)))
                {
                    _email = _name.ToLower() + "." + _surname.ToLower() + "@gmail.com";
                }
            }
            get
            {
                return _name;
            }
        }


        public string Surname
        {
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    bool check = char.IsLetter(value[i]);

                    if (check)
                        this._surname = value;
                    else
                        Console.WriteLine("Soyad daxil edilerken yalniz herflerden istifade edin!");
                }



                /*
                     Name set edildikden sonra Surname set edilerse, if blokunun serti true oldugu ucun bloka girecek 
                   ve  email fieldinin deyeri bu blok icinde set edilecek.
                 */
                if (!(string.IsNullOrWhiteSpace(_name)) && !(string.IsNullOrEmpty(_name)))
                {
                    _email = _name.ToLower() + "." + _surname.ToLower() + "@gmail.com";
                }
            }
            get
            {
                return _surname;
            }
        }
    }
}
