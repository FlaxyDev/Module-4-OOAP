using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    class TwoStoreyHouse : Building
    {
        protected override void BuildFoundation()
        {
            Console.WriteLine("Building foundation for two-storey house.");
        }

        protected override void BuildWalls()
        {
            Console.WriteLine("Building walls for two-storey house.");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("Building roof for two-storey house.");
        }

        protected override bool AddMansard()
        {
            Console.WriteLine("Do you want to add a mansard? (yes/no)");
            string input = Console.ReadLine();
            return input.ToLower() == "yes";
        }

        protected override bool AddBalcony()
        {
            Console.WriteLine("Do you want to add a balcony? (yes/no)");
            string input = Console.ReadLine();
            return input.ToLower() == "yes";
        }

        protected override bool AddGarage()
        {
            Console.WriteLine("Do you want to add a garage? (yes/no)");
            string input = Console.ReadLine();
            return input.ToLower() == "yes";
        }

        protected override bool AddVeranda()
        {
            Console.WriteLine("Do you want to add a veranda? (yes/no)");
            string input = Console.ReadLine();
            return input.ToLower() == "yes";
        }
    }
}
