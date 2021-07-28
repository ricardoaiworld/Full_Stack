using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IInteractionRepository _interactionRepository;
        private readonly IClientRepository _clientRepository;
        public EmployeeService(IEmployeeRepository employeeRepository, IInteractionRepository interactionRepository, IClientRepository clientRepository)
        {
            _employeeRepository = employeeRepository;
            _interactionRepository = interactionRepository;
            _clientRepository = clientRepository;
        }

        public async Task<EmployeeCardResponseModel> AddNewEmployee(EmployeeAddRequestModel requestModel)
        {
            var employee = new Employee
            {
                Name = requestModel.Name,
                Password = requestModel.Password,
                Designation = requestModel.Designation,
            };

            var createdEmployee = await _employeeRepository.AddAsync(employee);
            var employeeCard = new EmployeeCardResponseModel
            {
                Id = createdEmployee.Id,
                Name = createdEmployee.Name
            };
            return employeeCard;
        }

        

        public async Task<List<EmployeeCardResponseModel>> GetAllEmployees()
        {
            var employees = await _employeeRepository.GetAllEmployees();
            var employeeCards = new List<EmployeeCardResponseModel>();
            foreach (var employee in employees)
            {
                employeeCards.Add(new EmployeeCardResponseModel
                {
                    Id = employee.Id,
                    Name = employee.Name
                }); ;
            }
            return employeeCards;
        }

        public async Task<EmployeeDetailsModel> GetEmployeeDetails(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            var interactions = await _interactionRepository.GetInteractionsByEmployeeId(id);
            var inters = new List<InteractionCardResponseModel>();
            foreach (var i in interactions)
            {
                var client = await _clientRepository.GetByIdAsync(i.ClientId);
                inters.Add(new InteractionCardResponseModel
                {
                    Id = i.Id,
                    ClientId = i.ClientId,
                    EmpId = i.EmpId,
                    IntType = i.IntType,
                    IntDate = i.IntDate,
                    Remarks = i.Remarks,
                    ClientName = client.Name

                });
            }
            var employeeDetails = new EmployeeDetailsModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Password = employee.Password,
                Designation = employee.Designation,
                Interactions = inters
            };
            return employeeDetails;
        }

        public async Task<EmployeeDetailsModel> UpdateEmployee(EmployeeDetailsModel model)
        {
            var employee = new Employee
            {
                Id = model.Id,
                Password = model.Password,
                Name = model.Name,
                Designation = model.Designation

            };
            var updatedEmployee = await _employeeRepository.UpdateAsync(employee);
            return null;
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = new Employee
            {
                Id = id
            };
            await _employeeRepository.DeleteAsync(employee);
        }
    }
}
