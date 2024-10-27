using System;

namespace Module7_7_HW_03
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public Cart cart;

        public int Number { get; set; }

        public Order() 
        { 
            cart = new Cart();
        }

        public void AddProductToCart(Product product)
        {
            cart.AddProduct(product);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Информация по заказу: ");
            Console.WriteLine($"Ваш заказ№{Number}, от {Delivery.Date}, {Delivery.GetInfo()}");
            cart.ViewCartProducts();
        }
    }
}
