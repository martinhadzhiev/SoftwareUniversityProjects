namespace StudentsJoinedToSpecialties
{
    public class StudentSpecialty
    {
        public StudentSpecialty(int facultyNumber, string specialtyName)
        {
            this.FacultyNumber = facultyNumber;
            this.SpecialtyName = specialtyName;
        }
        public int FacultyNumber { get; set; }

        public string SpecialtyName { get; set; }
    }
}
