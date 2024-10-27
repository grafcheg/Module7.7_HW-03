using System;

namespace Module7_7_HW_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создание и заполнение массива с продуктами
            Product[] productsArray = new Product[5];
            for (int i = 0; i < productsArray.Length; i++)
            {
                productsArray[i] = new Product() { Name = String.Format("Товар №{0}", i) };
            }

            // создание профилей
            Account myAccount1 = new Account();
            Account myAccount2 = new Account("г. Владивосток, ул. Московская, д. 1");

            // вывод начальной информации о профилях
            myAccount1.DisplayAccount();
            myAccount2.DisplayAccount();
            Console.WriteLine();

            // первый заказ
            // доставка на дом
            HomeDelivery homeDelivery = new HomeDelivery();
            Order<Delivery> order1 = new Order<Delivery>() { Delivery = homeDelivery, Number = 123 };
            order1.Delivery.SetAddress(myAccount1.GetAddress());
            order1.AddProductToCart(productsArray[0]);
            order1.AddProductToCart(productsArray[1]);
            myAccount1.AddOrder(order1);

            // второй заказ
            // доставка в ПВЗ
            PickPointDelivery pickPointDelivery = new PickPointDelivery();
            Order<Delivery> order2 = new Order<Delivery>() { Delivery = pickPointDelivery, Number = 124 };
            order2.Delivery.SetAddress(myAccount1.GetAddress());
            order2.AddProductToCart(productsArray[4]);
            order2.AddProductToCart(productsArray[3]);
            myAccount1.AddOrder(order2);

            // третий заказ
            // доставка в магазин
            ShopDelivery shopDelivery = new ShopDelivery();
            Order<Delivery> order3 = new Order<Delivery>() { Delivery = shopDelivery, Number = 1 };
            order3.Delivery.SetAddress(myAccount2.GetAddress());
            order3.AddProductToCart(productsArray[1]);
            order3.AddProductToCart(productsArray[3]);
            myAccount2.AddOrder(order3);


            // вывод информации о профилях с добавленными заказами
            myAccount1.DisplayAccount();
            myAccount1.ShowOrders();
            Console.WriteLine();
            myAccount2.DisplayAccount();
            myAccount2.ShowOrders();

            Console.ReadLine();
        }
    }
}
