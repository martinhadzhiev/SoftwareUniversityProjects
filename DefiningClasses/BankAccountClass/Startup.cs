using System;
using System.Collections.Generic;

class Startup
{
    static void Main()
    {
        var command = Console.ReadLine();

        var accounts = new Dictionary<int, BankAccount>();

        while (command != "End")
        {
            var cmdArgs = command.Split();

            var cmdType = cmdArgs[0];

            switch (cmdType)
            {
                case "Create":
                    Create(cmdArgs, accounts);
                    break;

                case "Deposit":
                    Deposit(cmdArgs, accounts);
                    break;

                case "Withdraw":
                    Withdraw(cmdArgs, accounts);
                    break;

                case "Print":
                    Print(cmdArgs, accounts);
                    break;
            }

            command = Console.ReadLine();
        }
    }

    private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(accounts[id].ToString());
        }
    }

    private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        if (amount > accounts[id].Balance)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        accounts[id].Withdraw(amount);
    }

    private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        var amount = double.Parse(cmdArgs[2]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        accounts[id].Deposit(amount);
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
            return;
        }
        
            BankAccount account = new BankAccount();
            account.ID = id;

            accounts.Add(id, account);

    }
}
