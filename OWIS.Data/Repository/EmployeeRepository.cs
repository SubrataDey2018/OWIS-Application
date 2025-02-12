﻿using Microsoft.EntityFrameworkCore;
using OWIS.Data.Entities;
using OWIS.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWIS.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

            public Employee GetEmployee(int id)
            {
            var employee = _context.Employee
        .Include(e => e.Department)  // Include Department details
        .Include(e => e.Salary)      // Include Salary details
        .Where(e => e.EmployeeId == id)
        .Select(e => new Employee
        {
            EmployeeName = e.EmployeeName,
            DepartmentName = e.Department.DepartmentName,
            EmployeeSalary = e.Salary.EmployeeSalary  // Use renamed column
        })
        .FirstOrDefault();

            return employee;
        }
        }
    }
