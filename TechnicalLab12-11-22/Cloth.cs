using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalLab12_11_22
{
    internal class Cloth
    {
        public string Stock { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public int Sale { get; set; }



        public Cloth(string stock, int price)
        {
            Stock = stock;
            Price = price;
            if (Stock == "old")
            {
                Sale = Price - (Price * 20) / 100;
            }
            else
            {
                Console.WriteLine("Normal");
            }
        }

    }
}
