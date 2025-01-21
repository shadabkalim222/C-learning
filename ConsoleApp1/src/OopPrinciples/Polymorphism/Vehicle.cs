namespace ConsoleApp1.src.OopPrinciples.Polymorphism {
    public class Vehicle {
        public string Brand {get; set;}

        public string Model {get; set;}
        public int Year {get; set;}

        public virtual void Start() {
            System.Console.WriteLine("Starting the vehicle...");
        }

        public virtual void Stop() {
            System.Console.WriteLine("Stopping the vehicle...");
        }
    }
}