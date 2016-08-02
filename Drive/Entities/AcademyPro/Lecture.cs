using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drive.Entities.AcademyPro
{
    public class Lecture : ApplicationUnit
    {
        public Course Course { get; set; }
        public IList<Link> Links { get; set; }
    }
}