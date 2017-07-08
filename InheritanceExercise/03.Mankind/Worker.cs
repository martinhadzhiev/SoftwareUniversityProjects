namespace _03.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal workHoursPerDay;
        private decimal weekSalary;
        private decimal hourSalary;

        public Worker(string firstName, string lastName, decimal workHours, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHours;
            this.WeekSalary = weekSalary;
            this.hourSalary = this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        private decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        private decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 11)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"First Name: {this.FirstName}")
                .AppendLine($"Last Name: {this.LastName}")
                .AppendLine($"Week Salary: {this.WeekSalary:F2}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}")
                .AppendLine($"Salary per hour: {this.hourSalary:F2}");

            return result.ToString();
        }
    }
}
