using System;
using System.Collections.Generic;

namespace Module7_7_HW_03
{
    class Cart
    {
        private List<Product> products = new List<Product>();
        public string Id { get; set; }

        public void AddProduct(Product productToAdd)
        {
            products.Add(productToAdd);
        }

        public void ViewCartProducts()
        {
            Console.WriteLine("Продукты в заказе: ");

            foreach (Product product in products) 
            {
                Console.WriteLine($" - {product.Name}");
            }
        }

    }
}
