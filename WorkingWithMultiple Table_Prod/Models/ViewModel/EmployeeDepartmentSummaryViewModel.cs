namespace WorkingWithMultiple_Table_Prod.Models.ViewModel
{
    public class EmployeeDepartmentSummaryViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string DepartmentName { get; set; } = default!;
        public string DepartmentCode { get; set; } = default!;
    }
}
