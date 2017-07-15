namespace BashSoft.Exceptions
{
    using System;

    public class CourseNotFoundException : Exception
    {
        private const string InexistingCourse = "The course you are trying to get does not exist in the data base!";

        public CourseNotFoundException()
            : base(InexistingCourse)
        {

        }

        public CourseNotFoundException(string message)
            : base(message)
        {

        }
    }
}
