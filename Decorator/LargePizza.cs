namespace Decorator
{
    public class LargePizza : Pizza
    {
        public override double GetCost()
        {
            return 30;
        }

        public override string GetName()
        {
            return "LargePizza";
        }
    }
}