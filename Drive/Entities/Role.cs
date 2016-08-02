﻿using System.Collections.Generic;

namespace Drive.Entities
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public IList<User> Users { get; set; }

        public IList<Space> ReadPermissionSpaces { get; set; }
        public IList<Space> ModifyPermissionSpaces { get; set; }

        public IList<DataUnit> ReadPermissionDataUnits { get; set; }
        public IList<DataUnit> ModifyPermissionDataUnits { get; set; }
    }
}