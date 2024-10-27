using System;

namespace Module7_7_HW_03
{
    class HomeDelivery : Delivery
    {
        // свойства
        public override DateTime Date { get; } = DateTime.Now;

        // конструкторы

        public HomeDelivery()
        {
            Address = base.Address;
        }

        //методы
        public override string GetAddress()
        {
            return Address;
        }
        
        public override void SetAddress(string address)
        {
            Address = address;
        }

        public override string GetInfo()
        {
            return $"Доставка заказа на дом по адресу: {Address}";
        }
    }
}
