using System;

namespace AbstractClasses
{
    public abstract class Vehicle
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public abstract void Drive(); 

        // 1. Create a new abstract method (require implementation) 
        public abstract void TurboMode(); 
        // 2. Create a new virtual method (optional implementation) 
        public virtual void EngineLoad() 
        { 
            System.Console.WriteLine("The Vehicle Engine is Under Load!"); 
        } 
        // Implement in two fo your concrete classes 

        public virtual void Start() 
        { 
            System.Console.WriteLine("The Vehicle has Started"); 
        } 

        public void Stop() 
        { 
            System.Console.WriteLine("The Vehicle has Stopped"); 
        } 
    } 
} 

