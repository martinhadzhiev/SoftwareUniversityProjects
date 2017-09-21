namespace _05.Security_Door
{
    public class PinCodeCheck : SecurityCheck
    {
        private ISecurityPinCode securiryPinCode;

        public PinCodeCheck(ISecurityPinCode securiryPinCode)
        {
            this.securiryPinCode = securiryPinCode;
        }

        private bool IsValid(int pin)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            int pin = this.securiryPinCode.RequestPinCode();
            if (IsValid(pin))
            {
                return true;
            }

            return false;
        }
    }
}