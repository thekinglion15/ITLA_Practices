﻿namespace School.Domain.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreationDate = DateTime.Now;
            Deleted = false;
        }

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int CreationUser { get; set; }
        public int? UserMod { get; set; }
        public int? UserDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
