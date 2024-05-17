using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sdomino.Ordini
{
    internal class OrderReader
    {
        List<Order> orders = new();
        string path;

        public OrderReader(string path)
        {
            this.path = path;
        }

        public List<Order> GetOrders()
        {

            using var reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split(";");
                orders.Add(new Order
                {
                    Base = line[0],
                    Impasto = line[1],
                    Aggiunte = line[2].Split(",")

                });
            }

            return orders;
        }

    }
}


