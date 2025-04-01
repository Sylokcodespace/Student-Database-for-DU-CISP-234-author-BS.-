using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Database
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public int ZipCode { get; set; }
        public string MajorCode { get; set; }
        public float GPA { get; set; }
        public bool IsDeleted { get; set; }
    }
}
