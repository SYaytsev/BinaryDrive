using Drive.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drive.Entities.AcademyPro
{
    // Maybe implement ApplicationUnit
    public class Link : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Path { get; set; }
        public LinkType LinkType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}