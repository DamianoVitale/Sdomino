using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.Factory
{
    internal class PizzaFactory
    {
        public Pizza CreaPizza(string tipo, string impasto, params string[] aggiunte)
        {
            Pizza pizza = null;
            switch (tipo)
            {
                case "Bianca":
                    pizza = impasto == "Integrale" ? new PizzaBiancaIntegrale() : new PizzaBianca();
                    break;
                case "Margherita":
                    pizza = impasto == "Integrale" ? new PizzaMargheritaIntegrale() : new PizzaMargherita();
                    break;
                case "Napoletana":
                    pizza = impasto == "Integrale" ? new PizzaNapoletanaIntegrale() : new PizzaNapoletana();
                    break;
                default:
                    return null;
            }
            if (aggiunte.Length == 1)
            {
                switch (aggiunte[0])
                {
                    case "Prosciutto Cotto":
                        pizza = new ProsciuttoCottoDecorator(pizza);
                        break;
                    case "Prosciutto Crudo":
                        pizza = new ProsciuttoCrudoDecorator(pizza);
                        break;
                    case "Funghi":
                        pizza = new FunghiDecorator(pizza);
                        break;
                    case "Ananas":
                        pizza = new AnanasDecorator(pizza);
                        break;
                }
            }
            else
            {
                foreach (var a in aggiunte)
                {
                    if (!a.Contains("Ananas"))
                    {
                        if (a == "Prosciutto Cotto")
                            pizza= new ProsciuttoCottoDecorator(pizza);
                        if (a == "Prosciutto Crudo")
                            pizza= new ProsciuttoCrudoDecorator(pizza);
                        if (a == "Funghi")
                            pizza= new FunghiDecorator(pizza);
                    }
                    else pizza= new AnanasDecorator(pizza);
                }
            }
            return pizza;
        }
    }
}
