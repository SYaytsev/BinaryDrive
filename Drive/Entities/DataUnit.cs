using System.Collections.Generic;

namespace Drive.Entities
{
    public abstract class DataUnit : ApplicationUnit
    {
        public IList<User> ReadPermittedUsers { get; set; }
        public IList<User> ModifyPermittedUsers { get; set; }

        public IList<Role> ReadPermittedRoles { get; set; }
        public IList<Role> ModifyPermittedRoles { get; set; }
    }
}