public class Employee
{
    public string name;
    public double salary;
    public string position;
    public string department;
    public string email;
    public int age;

    public Employee(string name, double salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }

    public Employee(string name, double salary, string position, string department, string email)
        : this(name, salary, position, department)
    {
        this.email = email;
        this.age = -1;
    }

    public Employee(string name, double salary, string position, string department, int age)
        : this(name, salary, position, department)
    {
        this.age = age;
        this.email = "n/a";
    }

    public Employee(string name, double salary, string position, string department, string email, int age)
        : this(name, salary, position, department, email)
    {
        this.age = age;
    }
}