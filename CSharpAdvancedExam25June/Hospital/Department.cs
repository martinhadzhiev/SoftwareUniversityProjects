using System.Collections.Generic;

namespace Hospital
{
    public class Department
    {
        public Department()
        {
            this.Doctors = new List<string>();
            this.Patients = new List<string>();
            this.Rooms = new List<int>();
        }

        public string Name { get; set; }

        public List<string> Doctors { get; set; }

        public List<int> Rooms { get; set; }

        public List<string> Patients { get; set; }

    }
}
