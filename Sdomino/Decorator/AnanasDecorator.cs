using Sdomino.Factory;

internal class AnanasDecorator : PizzaDecorator
    {
        public AnanasDecorator(Pizza pizza) : base(pizza) { }

        public override double GetPrice()
        {
        return 0; 
        }
    }
