namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RepositorySorter
    {
        public void OrderAndTake(Dictionary<string, double> studentMarks, string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {
                this.PrintStudents(studentMarks
                    .OrderBy(x => x.Value)
                    .Take(studentsToTake)
                    .ToDictionary(x => x.Key, x => x.Value));
            }
            else if (comparison == "descending")
            {
                PrintStudents(studentMarks
                    .OrderByDescending(x => x.Value)
                    .Take(studentsToTake)
                    .ToDictionary(x => x.Key, x => x.Value));
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidQueryComparison);
            }
        }

        private void PrintStudents(Dictionary<string, double> studentsSorted)
        {
            foreach (var kv in studentsSorted)
            {
                OutputWriter.PrintStudent(kv);
            }
        }
    }
}
