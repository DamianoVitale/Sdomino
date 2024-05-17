using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sdomino.Factory;
using Sdomino.Logger;
using Sdomino.Ordini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdomino.IOC
{
    public static class IoCCotainer
    {
        public static IHost CreateHostBuilder()
        {
            return Host
                .CreateDefaultBuilder()
                .ConfigureServices((_, service) =>
                {
                    
                    service.AddSingleton<OrderReader>(provider => new OrderReader(Path.Order));
                    service.AddSingleton<PizzaFactory>();
                }).Build();
               
        }
    }

}

