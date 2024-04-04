using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building twoStoreyHouse = new TwoStoreyHouse();

            Console.WriteLine("Building a two-storey house with customization:");
            twoStoreyHouse.Build();

            Console.ReadLine();
        }
    }

}
