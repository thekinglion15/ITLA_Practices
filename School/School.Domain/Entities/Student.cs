namespace School.Domain.Entities
{
    internal class Student : Entities.Person
    {
        public DateTime? EnrollmentDate { get; set; }
    }
}
