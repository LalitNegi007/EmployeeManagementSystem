using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class DepartmentContext:DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)
        {

        }
        public DbSet<Departments> tbl_Employees { get; set; }

    }
}
