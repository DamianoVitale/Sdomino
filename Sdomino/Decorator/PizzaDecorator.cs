using Sdomino.Factory;

public abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override double GetPrice()
        {
            return _pizza.GetPrice();
        }
    }
