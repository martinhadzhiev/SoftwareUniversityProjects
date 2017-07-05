using System.Collections.Generic;

namespace Hospital
{
    public class Doctor
    {
        public Doctor()
        {
            this.Departments = new List<string>();
            this.Patients = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Departments { get; set; }

        public List<string> Patients { get; set; }
    }
}
