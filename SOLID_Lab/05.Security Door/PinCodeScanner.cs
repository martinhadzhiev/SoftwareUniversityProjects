namespace _05.Security_Door
{
    using System;

    public class PinCodeScanner : ISecurityPinCode

    {
        public int RequestPinCode()
        {
            Console.WriteLine("Enter your pin code:");
            return int.Parse(Console.ReadLine());
        }
    }
}
