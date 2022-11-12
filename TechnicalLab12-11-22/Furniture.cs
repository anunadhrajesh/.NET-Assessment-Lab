using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechnicalLab12_11_22
{
    internal class Furniture
    {
        public string Type { get; set; }
        public string Wood { get; set; }
        public int Price { get; set; }

        public Furniture(string wood)
        {
            Type = "table";
            Wood = wood;
            Price = 50;
        }
        public Furniture()
        {
            Type = "table";
            Wood = "teak";
            Price = 50;
        }
        public Furniture(string type, int price )
        {
            Type = type;
            Price = 50;
            Wood = "teak";
        }
    }

}