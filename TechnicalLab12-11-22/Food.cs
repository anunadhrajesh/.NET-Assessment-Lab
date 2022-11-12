using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalLab12_11_22
{
    internal class Food
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }

        public Food()
        {
            Name = "ABCD";
            Price = 0;
            Discount = 0;
        }
        public Food(float price, string name)
        {
            Name = name;
            if (price > 150)

                Discount = 10/100;

            Price = price - (price * Discount) / 10;
        }
    }
}   

