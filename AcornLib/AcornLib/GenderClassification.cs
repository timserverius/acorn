using System.Collections.Generic;

namespace AcornLib
{
    public class GenderClassification
    {
        public int GenderClassificationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Gender> Genders { get; set; }
    }
}
