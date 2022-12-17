using Homework2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{

    public class Car
    {
        public string City { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public ushort Year { get; set; }
        public Color GetColor { get; set; }
        public ushort EngineCpacity { get; set; }
        public int Km { get; set; }
        public Gearbox GetGearbox { get; set; }
        public decimal Price { get; set; }
    }
}
