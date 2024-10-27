using System;
using System.Collections.Generic;

namespace Module7_7_HW_03
{
    internal class Account
    {
        // поля
        private int id;
        protected string address;

        // свойства
        public int Id
        {
            get { return id; }
            set
            {
                if (value == 0 && value <= AccountId.IdCounter)
                    Console.WriteLine("Ошибка присвоения id для аккаунта");
                else
                    id = value;
            }
        }

        public List<Order<Delivery>> MyOrders { get; set; }        
        public string Address { get; set; }

        // конструкторы
        public Account()
        {
            id = AccountId.NextId();
            MyOrders = new List<Order<Delivery>>() { };
            address = "г. Москва, ул. Пушкина, дом Колотушкина";
        }

        public Account(string address) : this() 
        {
            this.address = address;
        }

        // методы
        public string GetAddress() { return address; }

        public void DisplayAccount()
        {
            Console.WriteLine($"***ВАШ ПРОФИЛЬ***\n - id: {id}\n - адрес: {address}\n - заказов: {MyOrders.Count}");
        }

        public void AddOrder(Order<Delivery> order)
        {
            MyOrders.Add(order);
        }

        public void ShowOrders()
        {
            foreach (Order<Delivery> order in MyOrders)
            {
                order.DisplayInfo();
            }
        }
    }
}
