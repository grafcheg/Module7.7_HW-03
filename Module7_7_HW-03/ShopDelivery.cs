using System;

namespace Module7_7_HW_03
{
    class ShopDelivery : Delivery
    {
        // свойства
        public override DateTime Date { get; } = DateTime.Now;

        // конструкторы

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
            return $"Доставка заказа в магазин по адресу: {Address}";
        }
    }
}
