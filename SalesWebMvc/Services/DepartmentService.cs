using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        // Construct

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Methods

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
