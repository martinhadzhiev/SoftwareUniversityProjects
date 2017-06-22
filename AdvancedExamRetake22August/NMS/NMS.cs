namespace NMS
{
    using System;
    using System.Text;

    class NMS
    {
        static void Main()
        {
            string line;
            var sb = new StringBuilder();

            while ((line = Console.ReadLine()) != "---NMS SEND---")
            {
                sb.Append(line);
            }

            var messageToSend = sb.ToString().ToLower();

            var delimiter = Console.ReadLine();
            var message = new StringBuilder();

            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (messageToSend[i] <= messageToSend[i + 1])
                {
                    message.Append(sb[i]);
                }
                else
                {
                    message.Append(sb[i]);
                    message.Append(delimiter);
                }
            }

            message.Append(sb[sb.Length - 1]);
            
            Console.WriteLine(message.ToString());
        }
    }
}
