using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Domain;
using E_commerce.Domain.CartAgg;
using E_commerce.Domain.CategoryAgg;

namespace E_commerce.Domain.ProductAgg
{
    public class Product:EntityBase
    {
        public string Name { get;private set; }
        public string Description { get;private set; }
        public float Price { get;private set; }
        public int Stock { get; private set; }

        public Guid CategoryId { get;private set; }
        public Category Category { get;private set; }

        public List<Cart> Carts { get; private set; }


        public Product(string name, string description, float price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public void Edit(string name, string description, float price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

    }
}
