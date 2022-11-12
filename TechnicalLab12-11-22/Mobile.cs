using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechnicalLab12_11_22
{
    internal class Mobile
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public int Price { get; set; }

        public string Company { get; set; }

        public void ReadData()
        {
            Console.WriteLine("Enter the Name");
            Console.ReadLine();
            Console.WriteLine("Enter the Model");
            Console.ReadLine();
            Console.WriteLine("Enter the Prize");
            Console.ReadLine();
            Console.WriteLine("Enter the Company");
            Console.ReadLine();
            SetData();
        }

        private void SetData()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Prize:" + Price);
            Console.WriteLine("Company:" + Company);
        }

        public void ReadData(string PName, string PModel, int PPrice, string PCompany)
        {
            Name = PName;
            Price = PPrice;
            Company = PCompany;
            Model = PModel;
            SetData();
        }


            public void ReadData( string PName, int PPrice, string PCompany)
        {
            Name = PName;
            Price = PPrice;
            Company = PCompany;
            Console.WriteLine("Enter the Name" + Name);
            Console.WriteLine("Enter the Model" + Price);
            Console.WriteLine("Enter the Price" + Company);

        }
    }
}
