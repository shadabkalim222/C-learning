// Coupling

// The degree of dependency between different classes

using ConsoleApp1.src.OopPrinciples.Coupling;

var order = new Order(new SmsSender());
order.PlaceOrder(); 