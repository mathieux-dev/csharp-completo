using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using SalesWebMvc.Data;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        public readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
