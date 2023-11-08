using System.Collections.ObjectModel;
using Spectre.Console;

namespace Cucumba.Demo.Pizzeria;

public class Fac
{
    public class O
    {
        private class PizzaMakerImplementation : IAmPizzaMaker
        {
            private readonly Stack<string> _ingredients;
            private PizzaMakerImplementation()
            {
                _ingredients = new Stack<string>();
            }

            public static IAmPizzaMaker New => new PizzaMakerImplementation();
            public IAmPizzaMaker CuBlat(Blat blat)
            {
                _ingredients.Push($"Blat {blat}");
                return this;
            }

            public IAmPizzaMaker PunSosDeRosii()
            {
                _ingredients.Push("Sos rossi");
                return this;
            }

            public IAmPizzaMaker PunMozzarella()
            {
                _ingredients.Push("Sos mozzarella");
                return this;
            }

            public IAmPizzaMaker Pun(Topping topping)
            {
                _ingredients.Push(topping.ToString());
                return this;
            }

            public Pizza BagLaCuptor()
            {
                return new Pizza(_ingredients);
            }
        }

        public static IAmPizzaMaker Pizza { get; } = PizzaMakerImplementation.New;
    }
}


public interface IAmPizzaMaker
{
    IAmPizzaMaker CuBlat(Blat blat);
    IAmPizzaMaker PunSosDeRosii();
    IAmPizzaMaker PunMozzarella();
    IAmPizzaMaker Pun(Topping topping);
    Pizza BagLaCuptor();
}

public enum Blat
{
    Subtire,
    Pufos
}

public enum Topping
{
    Pepperoni,
    Mozzarella,
    Ciuperci,
    Ardei,
    Ceapa,
    Masline,
    Sunca,
    Chorizzo,
    Ananas

}

public class Pizza
{
    public readonly ReadOnlyCollection<string> Ingredients;

    public Pizza(Stack<string> ingredients)
    {
        Ingredients = ingredients.ToList().AsReadOnly();
    }

    public void Print()
    {
        var table = new Table();
        table.Border(TableBorder.Ascii);

        table.AddColumn("Pizza the side view:");
        foreach (var ingredient in Ingredients)
        {
            table.AddRow(ingredient);
        }

        AnsiConsole.Write(table);
    }
}