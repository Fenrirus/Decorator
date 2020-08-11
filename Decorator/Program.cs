using System;
using System.Text;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pizza pizza = new LargePizza();
            pizza = new CheesePizzaDecorator(pizza);
            Console.WriteLine("Name: " + pizza.GetName() + " Cost: " + pizza.GetCost().ToString("C2"));
            Console.ReadLine();
        }
    }
}