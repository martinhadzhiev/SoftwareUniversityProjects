using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> bankAccounts;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public List<BankAccount> BankAccounts
    {
        get { return this.bankAccounts; }
        set { this.bankAccounts = new List<BankAccount>(value);}
    }
    
    public Person(string name , int age)
    {
        this.Name = name;
        this.Age = age;
        this.bankAccounts = new List<BankAccount>();
    }

    public Person(string name , int age , List<BankAccount> accounts)
    {
        this.Name = name;
        this.Age = age;
        this.BankAccounts = new List<BankAccount>(accounts);
    }

    public double GetBalance()
    {
        return this.bankAccounts.Sum(b => b.Balance);
    }
}
