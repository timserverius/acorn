namespace AcornLib
{
    public class SchoolGrade
    {
        public int SchoolGradeId { get; set; }
        public string Name { get; set; }

        public int SchoolGradeClassificationId { get; set; }
        public SchoolGradeClassification SchoolGradeClassification { get; set; }
    }
}
