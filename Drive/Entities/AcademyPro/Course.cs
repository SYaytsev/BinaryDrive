using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drive.Entities.AcademyPro
{
    public class Course : ApplicationUnit
    {
        public Space Space { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public IList<User> Listeners { get; set; }
    }
}