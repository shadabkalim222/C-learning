namespace ConsoleApp1.src.OopPrinciples.Polymorphism {
    public class Motorcyle : Vehicle {
        public int NumberOfWheels {get; set;}

        public override void Start() {
            System.Console.WriteLine("Starting the motorcycle...");
        }

        public override void Stop() {
            System.Console.WriteLine("Stopping the motorcycle...");
        }
    }
}