using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Order
    {
        public int ID { get; set; }
        public string InfoOrder { get; set; }

        public  Address ShippingAddress{ get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? EditTime { get; set; }


    }
}
