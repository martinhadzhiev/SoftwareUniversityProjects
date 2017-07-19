using System.Linq;

public class Smartphone : IBrowseable, ICallable
{
    public string Browse(string site)
    {
        if (!site.Any(char.IsDigit))
        {
            return $"Browsing: {site}!";
        }

        return "Invalid URL!";
    }

    public string Call(string number)
    {
        if (number.All(char.IsDigit))
        {
            return $"Calling... {number}";
        }

        return "Invalid number!";
    }
}