namespace _05.Security_Door
{
    public class Program
    {
        public static void Main()
        {
            CardScanner keyCardScanner = new CardScanner();
            PinCodeScanner pinCodeScanner = new PinCodeScanner();

            KeyCardCheck keyCardCheck = new KeyCardCheck(keyCardScanner);
            PinCodeCheck pinCodeCheck = new PinCodeCheck(pinCodeScanner);

            SecurityManager manager = new SecurityManager(keyCardCheck, pinCodeCheck);

            manager.Check();
        }
    }
}
