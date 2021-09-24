using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Vehicles!");

            Vehicle veh1 = new Ford();
            veh1.Model = "Mustang";

            Vehicle veh2 = new Dodge();
            veh2.Model = "Charger";

            veh1.Start();
            veh1.Drive();

            veh2.Start();
            veh2.Drive();

            veh1.TurboMode();
            veh2.TurboMode();

            veh1.EngineLoad();
        }
    }
}
