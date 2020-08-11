namespace Decorator
{
    public class MediumPizza : Pizza
    {
        public override double GetCost()
        {
            return 25;
        }

        public override string GetName()
        {
            return "Medium Pizza";
        }
    }
}