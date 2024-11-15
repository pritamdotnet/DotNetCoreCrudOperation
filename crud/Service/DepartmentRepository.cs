using crud.Interface;
using crud.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace crud.Service
{
    public class DepartmentRepository : IDepartment
    {
        private readonly APIDbContext _appDBContext;

        public DepartmentRepository(APIDbContext context)
        {
            _appDBContext = context ??
                throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _appDBContext.Departments.ToListAsync();
        }

        public async Task AddDepartment(Department department)
        {
            if (department == null)
            {
                throw new ArgumentNullException(nameof(department));
            }

            _appDBContext.Departments.Add(department);
            await _appDBContext.SaveChangesAsync();
        }


    }
}
