using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeCardResponseModel>> GetAllEmployees();

        Task<EmployeeCardResponseModel> AddNewEmployee(EmployeeAddRequestModel requestModel);

        Task<EmployeeDetailsModel> GetEmployeeDetails(int id);

        Task<EmployeeDetailsModel> UpdateEmployee(EmployeeDetailsModel model);

        Task DeleteEmployee(int id);
    }
}
