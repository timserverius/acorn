using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcornLib
{
    public class StudentSchoolEnrollment
    {
        public int StudentSchoolEnrollmentId { get; set; }

        public int StudentId { get; set; }
        public IStudent Student { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
