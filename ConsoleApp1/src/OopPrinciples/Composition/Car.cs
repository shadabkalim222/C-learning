namespace ConsoleApp1.src.OopPrinciples.Composition {
    public class Car {
        private Chassis chassis = new Chassis();
        private Engine engine = new Engine();
        private Seats seats = new Seats();
        private Wheels wheels = new Wheels();

        public void Drive() {
            chassis.Support();
            engine.Start();
            seats.Sit();
            wheels.Roll();
            Console.WriteLine("Car is driving");
        }
    }
}