using System.Collections.Generic;

namespace AcornLib
{
    public class SchoolDistrict
    {
        public int SchoolDistrictId { get; set; }
        public string Name { get; set; }

        public int SchoolRegionId { get; set; }
        public SchoolRegion SchoolRegion { get; set; }

        public virtual ICollection<School> Schools { get; set; }

        public virtual ICollection<IStudent> Students { get; set; }

        public virtual ICollection<SchoolGrade> SchoolGrades { get; set; }
    }
}
