using VendasWeb_MVC.Data;
using System.Collections.Generic;
using System.Linq;
using VendasWeb_MVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasWeb_MVC.Services
{
    public class DepartmentService
    {
        private readonly VendasWeb_MVCContext _context;
        public DepartmentService(VendasWeb_MVCContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}