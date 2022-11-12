using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalLab12_11_22
{
    internal class Animal
    {
        public string Name { get; set; }
        public int MaxLifeTime { get; set; }
        public string Food { get; set; }

        public Animal()
        {
            Name = "ABCD";
            MaxLifeTime = 5;
            Food = "nothing";
        } 
        //public Animal()
        //{
        //    name = AName;
        //    maxlifetime = AMaxLifeTime;
        //    food = AFood;

        //}
    }
}
