using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    abstract class Building
    {
        private List<string> chosenCustomizations = new List<string>();

        public void Build()
        {
            BuildFoundation();
            BuildWalls();
            BuildRoof();
            Customize();
            PrintChosenCustomizations();
        }

        protected abstract void BuildFoundation();
        protected abstract void BuildWalls();
        protected abstract void BuildRoof();

        protected virtual void Customize()
        {
            Console.WriteLine("Adding basic customization...");

            if (AddMansard())
                chosenCustomizations.Add("Mansard");

            if (AddBalcony())
                chosenCustomizations.Add("Balcony");

            if (AddGarage())
                chosenCustomizations.Add("Garage");

            if (AddVeranda())
                chosenCustomizations.Add("Veranda");
        }

        protected virtual bool AddMansard() { return false; }
        protected virtual bool AddBalcony() { return false; }
        protected virtual bool AddGarage() { return false; }
        protected virtual bool AddVeranda() { return false; }

        private void PrintChosenCustomizations()
        {
            Console.WriteLine("\nChosen customizations:");
            foreach (var customization in chosenCustomizations)
            {
                Console.WriteLine(customization);
            }
        }
    }
}
