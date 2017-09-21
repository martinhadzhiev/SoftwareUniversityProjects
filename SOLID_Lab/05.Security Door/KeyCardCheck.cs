namespace _05.Security_Door
{
    public class KeyCardCheck : SecurityCheck
    {
        private ISecurityCard securityCard;

        public KeyCardCheck(ISecurityCard securityCard)
        {
            this.securityCard = securityCard;
        }

        private bool IsValid(string code)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            string code = securityCard.RequestKeyCard();
            if (IsValid(code))
            {
                return true;
            }

            return false;
        }
    }
}