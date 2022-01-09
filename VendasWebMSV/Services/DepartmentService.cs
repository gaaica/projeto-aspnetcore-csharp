using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMSV.Models;

namespace VendasWebMSV.Services
{
    public class DepartmentService
    {
        private readonly VendasWebMSVContext _context;

        public DepartmentService(VendasWebMSVContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
