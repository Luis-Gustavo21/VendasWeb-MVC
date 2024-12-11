using VendasWeb_MVC.Data;
using System.Collections.Generic;
using System.Linq;
using VendasWeb_MVC.Models;

namespace VendasWeb_MVC.Services
{
    public class DepartmentService
    {
        private readonly VendasWeb_MVCContext _context;
        public DepartmentService(VendasWeb_MVCContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Nome).ToList();
        }
    }
}