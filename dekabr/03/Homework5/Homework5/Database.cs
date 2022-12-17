using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
   public class Database
    {
       public List<Person> people = new List<Person>();

        public Database()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname()
                };
                people.Add(person);
            }
        }
    }
}
