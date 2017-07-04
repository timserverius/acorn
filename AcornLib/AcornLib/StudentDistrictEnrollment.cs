using System;

namespace AcornLib
{
    public class StudentDistrictEnrollment
    {
        public int StudentDistrictEnrollmentId { get; set; }
        public int StudentId { get; set; }
        public IStudent Student { get; set; }

        public string StudentNumber { get; set; }

        public int SchoolDistrictId { get; set; }
        public SchoolDistrict SchoolDistrict { get; set; }

        public DateTime EnrollementDate { get; set; }
    }
}
