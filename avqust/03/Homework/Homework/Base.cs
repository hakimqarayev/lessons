using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Base
    {

        private int _id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int EditUser { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }


        public int ID
        {
            get
            {
                return _id;
            }

            private set
            {
            }
        }


        static int a = 1;

        public Base()
        {
            _id = a;
            a++;
        }
    }
}
