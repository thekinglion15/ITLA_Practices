namespace School.Domain.Entities
{
    public abstract class Person : Core.BaseEntity
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
    }
}
