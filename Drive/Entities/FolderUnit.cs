using System.Collections.Generic;

namespace Drive.Entities
{
    public class FolderUnit : ApplicationUnit
    {
        public IList<DataUnit> DataUnits { get; set; }
    }
}