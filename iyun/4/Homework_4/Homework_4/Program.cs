using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {/*
             Homework 4:
             Araşdırdığınız dəyişən tipləri barədə bir yazı hazırlayacaqsız. 
             Hər bir data type'ın nə kimi bir dəyər aldığını,
             neçə bit olduğunu və s. araşdırın.
            */


            /*
                C#-da dəyişən tipləri 2 yere ayrılır. Primitive(Value) və Reference type data tiplər. 
             Value types - özündə yalnızca qiymət və məlumat daşıyan dəyişən tipləridir.
             Program başlayanda bu tiplərin birbaşa dəyəri RAM-ın stack sahəsində saxlanılır. 
             Və hər bir tip üçün öncədən ölçü təyin edilmişdir.
              
                int tipi, C Sharp-da ən çox istifadə edilən tam ədəd tiplərindən biridir.
             32 bitlik rəqəm aralığına malikdir. 
             Dəyər aralığı: -2,147,483,,648 --- 2,147,483,,647
             İnt dəyişən tipi signed(işarəli- mənfi, müsbət) tiplərə daxildir.

                Uint(Unsigned int) - unsigned int 32 bitlik primitiv data tipdir. 
             Müsbət dəyərlər alır. 0 --- 4,294,967,296 

                Long 64 bitlik data tipidir. tam ədədlər üçün istifadə olunur.
             Dəyər aralığı: -9,223,372,036,854,775,808 --- 9,223,372,036,854,775,807  

                Ulong - Long kimi 64 bitlik data tipidir. Sadəcə usigned olduğu üçün 
             0 və 18446744073709551615 arası qiymət alır.

                Short 16 bitlik tam ədədlər üçün istifadə olunan data tipidir.
             Dəyər aralığı: -32768 --- 32767

                Ushort Short kimi 16 bitlik data tipidir. Müsbət dəyərlər alır
             Dəyər aralığı: 0 --- 65535

                Byte - 8 bitlik müsbət dəyərlər alan data tipidir. 
             Dəyər aralığı: 0 --- 255 arasında qiymət alır.

                Sbyte bu data tipi də yaddaşda byte qeder yer tutur yəni 8 bit. 
             Lakin Signed Byte mənfi və müsbət dəyərlər ala bilir. 
             Dəyər aralığı: -128 --- 127


                Double - kesr ədədlər üçün istifadə olunan data tipidir. Kesr hissesinden sonra 15-17 rəqəm 
             istifadə olunar. C#-da kəsr tip deyiləndə default olaraq double tip götürülür.
             Yaddaşda 32 bitlik yer tutur. 
             Dəyər aralığı: -1.7976931348623157E+308 --- 1.7976931348623157E+308 


                Float da kəsr ədədləri saxlamaq üçün istifadə olunan data tipidir.
             32 bitlik həcmi var.Nöqtədən sonra ədədin kəsr hissəsinin dəqiqliyini 6-9 rəqəmə qədər
             qoruya bilir. C#-da Double deafult olaraq kəsr tip olduğu üçün fərqləndirmək üçün Float üçün 
             f suffix istifadə olunmalıdır.
             Dəyər aralığı: -3.40282347E+38 --- 3.40282347E+38

                   
                Decimal - kəsr ədələr saxlayan data tipidir. 128 bitlik həcmə sahibdir.
             Kəsr hisssədə 28 rəqəmə qədər saxlaya bilir. Float kimi Decimal-ı da fərqləndirmək üçün
             m suffix istifadə olunur.
             Dəyər aralığı: (-7.9 x 1028 to 7.9 x 1028) / 100to 28	
            
            
                 Char - özündə tək hərf və ya simvol saxlayan data tipidir.
             həcmi 16 bitdir. 



                Boolean - iki cavab saxlayan data tipidir. True-False
             Məntiqi əməlləri idarə etmək üçün istifadə olunur.


            Bütün value type dəyişənlərin default dəyəri sıfırdır. Boolean-nin isə false



            Reference data types
                Reference type-lar RAM-ın heap sahəsində saxlanılır
                Həm heap həm stack sahəsində saxlanır, Sadəcə heap-də programçının kod tərəfdə yaratdığı
                obyektlərin dəyərləri üçün yer bron edilir. Stack-də isə bu dəyərlərin ümumi hashcode-u saxlanılır.

            Object, Classes, İnterfaces və String reference type-dır.
            Default dəyəri null olur. Dəyər aralığı olmur

            


         


            
             */

        }
    }
}
