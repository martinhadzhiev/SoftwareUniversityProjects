namespace _04.Recharge
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            RechargeStation station = new RechargeStation();

            Employee mitko = new Employee("mitaka");
            Robot pesho = new Robot("pesho", 200);

            station.Recharge(pesho);
        }
    }
}
