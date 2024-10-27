namespace Module7_7_HW_03
{
    internal class AccountId
    {
        public static int IdCounter = 0;
        public static int NextId() { return IdCounter++; }
    }
}
