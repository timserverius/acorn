using System.Collections.Generic;

namespace AcornLib
{
    public class SchoolGradeClassification
    {
        public int SchoolGradeClassificationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SchoolGrade> SchoolGrades { get; set; }
    }
}
