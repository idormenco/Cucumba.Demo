// See https://aka.ms/new-console-template for more information

using Cucumba.Demo.Calculator;
using Cucumba.Demo.Pizzeria;

var value = Dear.Calculator
    .Add(3)
    .Subtract(1)
    .Please();

Console.WriteLine(value);

var pizza = Fac.O.Pizza
    .CuBlat(Blat.Pufos)
    .PunSosDeRosii()
    .PunMozzarella()
    .Pun(Topping.Ananas)
    .Pun(Topping.Ciuperci)
    .Pun(Topping.Pepperoni)
    .Pun(Topping.Ceapa)
    .BagLaCuptor();

pizza.Print();