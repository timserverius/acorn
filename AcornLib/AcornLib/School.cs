using System.Collections.Generic;

namespace AcornLib
{
    public class School
    {
        public int SchoolId { get; set; }
        public string SchoolCode { get; set; }
        public string Name { get; set; }

        public int SchoolDistrictId { get; set; }
        public virtual SchoolDistrict SchoolDistrict { get; set; }

        public ICollection<SchoolGrade> SchoolGrades { get; set; }

        public ICollection<IStudent> Students { get; set; }
    }
}
