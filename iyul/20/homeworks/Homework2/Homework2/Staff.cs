using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Staff
    {
        public static string domain = "oxu.az";
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; } //1=Male, 0=Female

        private string _email;

        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                if (Name!=null && Surname!=null)
                {
                    this._email = (Name+Surname).ToLower() + "@" + Staff.domain;
                }
            }

        }
    }
}
