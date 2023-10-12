using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Employee.Controllers
{
    public class Employee : Controller
    {
        private Employee db = new Employee();

        //public IEnumerable<object> Employee { get; private set; }

        //public IActionResult Index()
        //{

        //    return View();
        //}

        public ActionResult Index(string departmentName, string firstName, string lastName)
        {
            //var query = db.Employee
            //    .Where(e =>
            //        e.Skills.Contains("Communication") &&
            //        e.Skills.Contains("Organization") &&
            //        e.Skills.Contains("Project Management"));

            //if (!string.IsNullOrWhiteSpace(departmentName))
            //{
            //    query = query.Where(e => e.Department.DepartmentName == departmentName);
            //}

            //if (!string.IsNullOrWhiteSpace(firstName))
            //{
            //    query = query.Where(e => e.FirstName.Contains(firstName));
            //}

            //if (!string.IsNullOrWhiteSpace(lastName))
            //{
            //    query = query.Where(e => e.LastName.Contains(lastName));
            //}

            //var employeesWithSkills = query.ToList();

            //return View(employeesWithSkills);
            return View();
        }

    }
}
