namespace StudentsJoinedToSpecialties
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StudentsJoinedToSpecialties
    {
        static void Main()
        {
            var students = new List<Student>();
            var specialties = new List<StudentSpecialty>();

            var line = Console.ReadLine();

            while (line != "Students:")
            {
                var lineArgs = line.Trim().Split();
                var specialtyName = string.Concat(lineArgs[0], " ", lineArgs[1]);
                var facultyNum = int.Parse(lineArgs[2]);

                var studentSpecialty = new StudentSpecialty(facultyNum,specialtyName);
                specialties.Add(studentSpecialty);

                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "END")
            {
                var lineArgs = line.Trim().Split();
                var facultyNumber = int.Parse(lineArgs[0]);
                var name = string.Concat(lineArgs[1], " ", lineArgs[2]);
                
                var student = new Student(facultyNumber,name);

                students.Add(student);

                line = Console.ReadLine();
            }

            var studentsSpecialties = students.OrderBy(s => s.Name).Join(specialties,st => st.FacultyNumber,sp => sp.FacultyNumber,((student, specialty) =>
                {
                    return $"{student.Name} {student.FacultyNumber} {specialty.SpecialtyName}";
                }));

            foreach (var studentsSpecialty in studentsSpecialties)
            {
                Console.WriteLine(studentsSpecialty);
            }
        }
    }
}
