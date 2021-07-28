using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class EmployeeRepository : EfRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ClientSystemDbContext dbContext) : base(dbContext)
        {
        }

        public Task<Employee> AddEmployee()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await _dbContext.Employees.OrderBy(c => c.Name).ToListAsync();
            return employees;
        }
    }
}
