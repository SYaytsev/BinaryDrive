using System.Collections.Generic;

namespace Drive.Entities
{
    public class Space : ApplicationUnit
    {
        public int MaxCountOfFiles { get; set; }
        // absent in Data Model file
        public int MaxSizeOfFiles { get; set; }

        public IList<User> Members { get; set; }
        public IList<DataUnit> DataUnits { get; set; }

        public IList<User> ReadPermittedUsers { get; set; }
        public IList<User> ModifyPermittedUsers { get; set; }

        public IList<Role> ReadPermittedRoles { get; set; }
        public IList<Role> ModifyPermittedRoles { get; set; }
    }
}