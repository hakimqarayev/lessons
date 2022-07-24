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
            /*
             Task in Lesson 3: (bunu da ev tapşırığı olaraq edin)
             İndi belə bir şey edirsiz ki, fərz edin mən staff yaradandan sonra istəyirəm ki, həmin işçiyə xoş gəlmisiniz və şifrə
             dəyişdirmə maili göndərim. Yəni sistemə yeni bir işçi əlavə olunanda həm xoş gəldiniz maili getsin həm də yeni bir
             şifrə daxil etməsi üçün link göndərilsin. İki email gedəcək burda. Bunu da bir çox yerdə istifadə edəcəyimi nəzərə alıb
             edin sonra mən yazacam. Email falan göndərməyinizə ehtiyyac yoxdur ekrana xoş gəldiniz emaili göndərildi və şifrə
             emaili göndərildi yazsa kifayətdir.
            
             */

            Staff st = new Staff();
            st.Name = "Hakim";
            st.Surname = "Qarayev";
            st.Email = "hakim.qarayev";
            st.Gender = 1;


            Helper.Welcome(st.Email);
            Helper.ForgetPass(st.Email);

        }
    }
}


