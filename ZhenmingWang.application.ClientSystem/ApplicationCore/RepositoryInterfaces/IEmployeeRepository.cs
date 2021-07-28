using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IEmployeeRepository : IAsyncRepository<Employee>
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee> AddEmployee();
    }
}
