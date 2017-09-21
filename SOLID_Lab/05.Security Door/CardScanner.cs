namespace _05.Security_Door
{
    using System;

    public class CardScanner : ISecurityCard
    {
        public string RequestKeyCard()
        {
            Console.WriteLine("Slide your key card");
            return Console.ReadLine();
        }
    }
}
