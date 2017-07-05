using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    static void Main()
    {
        var employees = new List<Employee>();
        var lineCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < lineCount; i++)
        {
            var line = Console.ReadLine().Trim().Split();

            if (line.Length == 4)
            {
                var name = line[0];
                var salary = double.Parse(line[1]);
                var position = line[2];
                var department = line[3];

                var emp = new Employee(name, salary, position, department);
                employees.Add(emp);
            }
            else if (line.Length == 5)
            {
                var name = line[0];
                var salary = double.Parse(line[1]);
                var position = line[2];
                var department = line[3];
                int age;

                var isInt = int.TryParse(line[4], out age);

                if (isInt)
                {
                    var emp = new Employee(name, salary, position, department,age);
                    employees.Add(emp);
                }
                else
                {
                    var email = line[4];
                    var emp = new Employee(name, salary, position, department,email);
                    employees.Add(emp);
                }

                
            }
            else
            {
                var name = line[0];
                var salary = double.Parse(line[1]);
                var position = line[2];
                var department = line[3];
                var email = line[4];
                var age = int.Parse(line[5]);

                var emp = new Employee(name, salary, position, department,email,age);
                employees.Add(emp);
            }
        }

       // var highestAvg = employees.GroupBy(e => e.department).ToList().Max(p => p.Average(e => e.salary));

        var dep = employees.GroupBy(e => e.department).OrderByDescending(e => e.Average(em => em.salary))
            .FirstOrDefault().Key;

        Console.WriteLine($"Highest Average Salary: {dep}");
        foreach (var employee in employees.Where(e => e.department == dep).OrderByDescending(e => e.salary))
        {
            Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
        }
    }
}