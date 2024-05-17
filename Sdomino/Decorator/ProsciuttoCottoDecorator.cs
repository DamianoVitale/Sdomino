using Sdomino.Factory;

internal class ProsciuttoCottoDecorator : PizzaDecorator
    {
        public ProsciuttoCottoDecorator(Pizza pizza) : base(pizza) { }

        public override double GetPrice() => _pizza.GetPrice() + 1.00;
    }
