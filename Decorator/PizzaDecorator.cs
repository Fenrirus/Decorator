namespace Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double GetCost()
        {
            return _pizza.GetCost();
        }

        public override string GetName()
        {
            return _pizza.GetName();
        }
    }
}