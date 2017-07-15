namespace BashSoft
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class RepositoryFilter
    {
        public void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilters, int studentsToTake)
        {
            if (wantedFilters == "excellent")
            {
                this.FilterAndTake(studentsWithMarks, x => x >= 5, studentsToTake);
            }
            else if (wantedFilters == "average")
            {
                this.FilterAndTake(studentsWithMarks, x => x >= 3.5 && x < 5, studentsToTake);
            }
            else if (wantedFilters == "poor")
            {
                this.FilterAndTake(studentsWithMarks, x => x < 3.5, studentsToTake);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidStudentFilter);
            }
        }

        private void FilterAndTake(Dictionary<string, double> studentsWithMarks, Predicate<double> givenFilter, int studentsToTake)
        {
            int counter = 0;
            foreach (var studentMark in studentsWithMarks)
            {
                if (counter == studentsToTake)
                {
                    break;
                }

                if (givenFilter(studentMark.Value))
                {
                    OutputWriter.PrintStudent(new KeyValuePair<string, double>(studentMark.Key,studentMark.Value));
                    counter++;
                }
            }
        }
    }
}
