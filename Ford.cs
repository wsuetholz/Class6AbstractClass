using System; 

namespace AbstractClasses 
{ 
    public class Ford : Vehicle 
    { 
        public string Color { get; set; }
        public Ford() 
        { 
            Make = "Ford"; 
        } 

        public override void Drive() 
        { 
            System.Console.WriteLine("Driving a Ford"); 
        } 

        public override void TurboMode() 
        { 
            System.Console.WriteLine("Ford Turbo Mode!"); 
        } 
    } 
} 

