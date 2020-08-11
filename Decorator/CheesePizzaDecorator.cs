namespace Decorator
{
    public class CheesePizzaDecorator : PizzaDecorator
    {
        public CheesePizzaDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 5;
        }

        public override string GetName()
        {
            return _pizza.GetName() + " with Cheese";
        }
    }
}