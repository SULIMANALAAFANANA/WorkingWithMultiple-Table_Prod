namespace WorkingWithMultiple_Table_Prod.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set;}
        public string? Gender { get; set; }
        public Department Department { get; set; } = default!;
    }
}
