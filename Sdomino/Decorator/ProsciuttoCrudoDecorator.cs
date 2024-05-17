using Sdomino.Factory;

internal class ProsciuttoCrudoDecorator : PizzaDecorator
    {
        public ProsciuttoCrudoDecorator(Pizza pizza) : base(pizza) { }

        public override double GetPrice() => _pizza.GetPrice() + 2.00;
    }
