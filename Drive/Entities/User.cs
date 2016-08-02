using System.Collections.Generic;

namespace Drive.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        // type from Data Model file - int
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public IList<Role> Roles { get; set; }

        public IList<Space> ReadPermissionSpaces { get; set; }
        public IList<Space> ModifyPermissionSpaces { get; set; }

        public IList<DataUnit> ReadPermissionDataUnits { get; set; }
        public IList<DataUnit> ModifyPermissionDataUnits { get; set; }

        //public IList<Course> Courses { get; set; }
    }
}