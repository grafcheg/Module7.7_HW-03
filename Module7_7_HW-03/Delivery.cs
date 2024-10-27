using System;

namespace Module7_7_HW_03
{
    abstract class Delivery
    {
        public abstract DateTime Date { get; }
        public string Address { get; set; } = "";

        public abstract string GetAddress();
        public abstract void SetAddress(string address);
        public abstract string GetInfo();
    }
}
