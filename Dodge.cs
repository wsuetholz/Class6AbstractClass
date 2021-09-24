using System;

namespace AbstractClasses
{
    public class Dodge : Vehicle
    {
        public Dodge ()
        {
            Make = "Dodge";
        }

        public override void Drive()
        {
            System.Console.WriteLine("You are driving a Dodge");
        }
        public override void TurboMode()
        {
            System.Console.WriteLine("Dodge Turbo Mode!");
        }
     }
}