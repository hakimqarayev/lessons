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
             Generic class yaradaraq (Repository) Add, Update, Get, Delete method'larını yazın. Həmin repository'nin instance'ını
             Student, Customer, Techer və Book class'ları ilə yaradıb hər bir method'u istifadə edə bilməlisiz. GenericRepository
             class'ı üçün İnterface'də istifadə edin.
            */

            Student student = new Student()
            {
                Id = 1,
                Name = "Hakim",
                Surname = "Qarayev",
                ClassName = "11a"
            };
            GenericRepository<Student> genericStudent = new GenericRepository<Student>();
            genericStudent.Add(student);
            genericStudent.Update(student);
            genericStudent.Get(student);
            genericStudent.Delete(student);

            Book book1 = new Book()
            {
                Name = "Beyaz Diş",
                Page = 672,
                Genre = "Klassika",
                Author = new Author("Jack", "London", 1)
            };
            GenericRepository<Book> genericBook = new GenericRepository<Book>();
            genericBook.Add(book1);
            genericBook.Update(book1);
            genericBook.Get(book1);
            genericBook.Delete(book1);

            Book book2 = new Book()
            {
                Name = "1984",
                Page = 436,
                Genre = "Klassika",
                Author = new Author("George", "Orwell", 2)
            };
            genericBook.Add(book2);
            genericBook.Update(book2);
            genericBook.Get(book2);
            genericBook.Delete(book2);

            Teacher teacher = new Teacher()
            {
                Id = 3,
                Name = "Farid",
                Surname = "Hasanov",
                Salary = 2000
            };
            GenericRepository<Teacher> genericTeacher = new GenericRepository<Teacher>();
            genericTeacher.Add(teacher);
            genericTeacher.Update(teacher);
            genericTeacher.Get(teacher);
            genericTeacher.Delete(teacher);

            Customer customer = new Customer()
            {
                Id = 7,
                Name = "John",
                Surname = "Scott",
                Email = "johnscott@gmail.com",
                Number = 88888888
            };
            GenericRepository<Customer> genericCustomer = new GenericRepository<Customer>();
            genericCustomer.Add(customer);
            genericCustomer.Update(customer);
            genericCustomer.Get(customer);
            genericCustomer.Delete(customer);




            Console.ReadLine();
        }
    }
}
