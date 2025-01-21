namespace ConsoleApp1.src.OopPrinciples.Polymorphism {
    public class Car: Vehicle {
        public int NumberOfDoors {get; set;}

        public override void Start() {
            System.Console.WriteLine("Starting the vehicle...");
        }

        public override void Stop() {
            System.Console.WriteLine("Stopping the vehicle...");
        }
    }
}