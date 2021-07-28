using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRespository;
        private readonly IInteractionRepository _interactionRepository;
        private readonly IEmployeeRepository _employeeRepository;
        public ClientService(IClientRepository clientRepository, IInteractionRepository interactionRepository, IEmployeeRepository employeeRepository)
        {
            _clientRespository = clientRepository;
            _interactionRepository = interactionRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task<ClientCardResponseModel> AddNewClient(ClientAddRequestModel requestModel)
        {
            var client = new Client
            {
                Name = requestModel.Name,
                Phones = requestModel.Phones,
                Email = requestModel.Email,
                Address = requestModel.Address,
                AddedOn = DateTime.Now
            };

            var createdClient = await _clientRespository.AddAsync(client);
            var clientCard = new ClientCardResponseModel
            {
                Id = createdClient.Id,
                Name = createdClient.Name
            };
            return clientCard;
        }

      

        public async Task<List<ClientCardResponseModel>> GetAllClients()
        {
            var clients = await _clientRespository.GetAllClients();
            var clientCards = new List<ClientCardResponseModel>();
            foreach (var client in clients)
            {
                clientCards.Add(new ClientCardResponseModel
                {
                    Id = client.Id,
                    Name = client.Name
                }); ;
            }
            return clientCards;
        }

        public async Task<ClientDetailsModel> GetClientDetails(int id)
        {
            var client = await _clientRespository.GetByIdAsync(id);
            var interactions = await _interactionRepository.GetInteractionsByClientId(id);
            var inters = new List<InteractionCardResponseModel>();
            foreach (var i in interactions)
            {
                var employee = await _employeeRepository.GetByIdAsync(i.EmpId);
                inters.Add(new InteractionCardResponseModel
                {
                    Id = i.Id,
                    ClientId = i.ClientId,
                    EmpId = i.EmpId,
                    IntType = i.IntType,
                    IntDate = i.IntDate,
                    Remarks = i.Remarks,
                    EmpName = employee.Name
                    
                });
            }
            var clientDetails = new ClientDetailsModel
            {
                Id = client.Id,
                Name = client.Name,
                Phones = client.Phones,
                Email = client.Email,
                AddedOn = client.AddedOn,
                Address = client.Address,
                Interactions = inters
            };
            return clientDetails;
        }

        public async Task<ClientDetailsModel> UpdateClient(ClientDetailsModel model)
        {
            var client = new Client
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Phones = model.Phones,
                Address = model.Address,
                AddedOn = model.AddedOn

            };
            var updatedClient = await _clientRespository.UpdateAsync(client);
            return null;
        }

        public async Task DeleteClient(int id)
        {
            var client = new Client
            {
                Id = id
            };
            await _clientRespository.DeleteAsync(client);
        }
    }
}
