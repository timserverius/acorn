using System;

namespace AcornLib
{
    public class BaseStudent : Contact, IStudent
    {
        public int StudentId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int StudentDistrictEnrollmentId { get; set; }
        public StudentDistrictEnrollment DistrictEnrollment { get; set; }

        public int StudentSchoolEnrollment { get; set; }
        public StudentSchoolEnrollment SchoolEnrollment { get; set; }
    }
}
