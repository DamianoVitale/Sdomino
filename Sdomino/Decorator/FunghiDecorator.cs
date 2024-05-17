using Sdomino.Factory;

internal class FunghiDecorator : PizzaDecorator
    {
        public FunghiDecorator(Pizza pizza) : base(pizza) { }

        public override double GetPrice() => _pizza.GetPrice() + 2.00;
    }
