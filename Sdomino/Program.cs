using Sdomino.Factory;
using Sdomino.IOC;
using Sdomino.Logger;
using Sdomino.Ordini;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;


namespace Sdomino
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = IoCCotainer.CreateHostBuilder();
            var orderReader = host.Services.GetRequiredService<OrderReader>();
            var pizzaFactory = host.Services.GetRequiredService<PizzaFactory>();
            var orders = orderReader.GetOrders();


            

            foreach (var order in orders)
            {
                Pizza pizza = pizzaFactory.CreaPizza(order.Base, order.Impasto, order.Aggiunte);
                Scontrino scontrino = new Scontrino(pizza.GetPrice());
                CSVLogger logger = new CSVLogger(scontrino);
                logger.WriteOnFile(Path.Scontrini);

            }

        }
    }
}
