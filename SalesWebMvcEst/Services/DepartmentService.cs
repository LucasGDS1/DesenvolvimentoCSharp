using SalesWebMvcEst.Data;
using SalesWebMvcEst.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcEst.Services
{
    public class DepartmentService
    {
        public readonly SalesWebMvcEstContext _context;

        public DepartmentService(SalesWebMvcEstContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            //return _context.Department.ToList();
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
