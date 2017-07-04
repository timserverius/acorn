using System.Collections.Generic;

namespace AcornLib
{
    public abstract class Contact : IContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
