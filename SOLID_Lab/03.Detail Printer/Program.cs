namespace _03.Detail_Printer
{
    using System.Collections;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Employee gosho = new Employee("Gosho");
            Employee pesho = new Employee("Pesho");
            Manager mitko = new Manager("Mitko",new List<string>(){"213","213123","2143213"});

            IList<Employee> employees = new List<Employee>()
            {
                gosho,pesho,mitko
            };

            DetailsPrinter printer = new DetailsPrinter(employees);

            printer.PrintDetails();
        }
    }
}
