namespace AcornLib
{
    public class SchoolRegion
    {
        public int SchoolRegionId { get; set; }

        public string Name { get; set; }

        public int SchoolGradeClassificationId { get; set; }

        public SchoolGradeClassification SchoolGradeClassification { get; set; }
        
        public int GenderClassificationId { get; set; }

        public GenderClassification GenderClassification { get; set; }
    }
}
