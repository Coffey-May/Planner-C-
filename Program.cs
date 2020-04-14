using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Stories = 3,
                Width = 3,
                Depth = 3,

            };
            // Console.WriteLine(FiveOneTwoEigth);
            FiveOneTwoEigth.Designer("Coffey");
            FiveOneTwoEigth.Purchase("Coffey");
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Print();


            Building FiveOneTwoSeventh = new Building("512 7th Avenue")
            {
                Stories = 4,
                Width = 4,
                Depth = 4,

            };
            // Console.WriteLine(FiveOneTwoEigth);
            FiveOneTwoEigth.Designer("me");
            FiveOneTwoEigth.Purchase("you");
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Print();

            City ElDorado = new City("ElDorado", "Coffey May", 1984);
            ElDorado.AddBuilding(FiveOneTwoEigth);
            ElDorado.AddBuilding(FiveOneTwoSeventh);



            foreach (Building building in ElDorado.Buildings)
            {
                building.Print();
            }
        }
    }
}
