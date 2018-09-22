using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace TokenBasedOAuth.Web.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (var db = new EmployeeDBEntities())
            {
                return db.Employees.ToList();
            }
        }
    }
}
