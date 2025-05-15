using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;

namespace E_commerce.Domain.ProductAgg
{
    public class Product:EntityBase
    {
        public string Name { get;private set; }
        public string Description { get;private set; }

        public double Price { get;private set; }
        public int Stock { get; private set; }

        public Product(string name, string description, double price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public void Edit(string name, string description, double price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

    }
}
