﻿using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        public readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
