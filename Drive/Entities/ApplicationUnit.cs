using System;

namespace Drive.Entities
{
    public abstract class ApplicationUnit : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        // absent in Data Model file
        public DateTime LastModified { get; set; }

        public int OwnerId { get; set; }
        public User Owner { get; set; }
    }
}