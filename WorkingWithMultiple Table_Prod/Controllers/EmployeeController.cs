using Microsoft.AspNetCore.Mvc;
using WorkingWithMultiple_Table_Prod.Data;
using WorkingWithMultiple_Table_Prod.Models.ViewModel;

namespace WorkingWithMultiple_Table_Prod.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;

        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {


            // Using Merge model
            //    EmployeeDepartmentListViewModel emp = new EmployeeDepartmentListViewModel();
            //    var employees = context.Employees.ToList();
            //    var departments = context.Departments.ToList();
            //emp.employees = empData;
            //emp.departments = depData;


            //Using Join Model
            var data = (from e in context.Employees
                        join d in context.Departments
                        on e.Id equals d.Id
                        select new EmployeeDepartmentSummaryViewModel
                        {
                            Id = e.Id,
                            FirstName = e.FirstName,
                            MiddleName = e.MiddleName,
                            LastName = e.LastName,
                            Gender = e.Gender,
                            DepartmentCode = d.DepartmentCode,
                            DepartmentName = d.DepartmentName,

                        }).ToList();
            return View(data);
        }
    }
}
