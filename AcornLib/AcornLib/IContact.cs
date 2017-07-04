using System.Collections.Generic;

namespace AcornLib
{
    public interface IContact
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleInitial { get; set; }
        ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}