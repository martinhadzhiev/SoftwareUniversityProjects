namespace StudentsJoinedToSpecialties
{
    public class Student
    {
        public Student(int facultyNum, string name)
        {
            this.FacultyNumber = facultyNum;
            this.Name = name;
        }
        public int FacultyNumber { get; set; }

        public string Name { get; set; }
    }
}
