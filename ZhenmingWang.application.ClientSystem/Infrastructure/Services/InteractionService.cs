using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class InteractionService : IInteractionService
    {
        private readonly IInteractionRepository _interactionRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IEmployeeRepository _employeeRepository;
        public InteractionService(IInteractionRepository interactionRepository, IClientRepository clientRepository, IEmployeeRepository employeeRepository)
        {
            _interactionRepository = interactionRepository;
            _employeeRepository = employeeRepository;
            _clientRepository = clientRepository;
        }

        public async Task<InteractionCardResponseModel> AddNewInteraction(InteractionAddRequestModel requestModel)
        {
            var interaction = new Interaction
            {
                ClientId = requestModel.ClientId,
                EmpId = requestModel.EmpId,
                IntType = requestModel.IntType,
                IntDate = requestModel.IntDate,
                Remarks = requestModel.Remarks
            };

            var createdInteraction = await _interactionRepository.AddAsync(interaction);
            var interactionCard = new InteractionCardResponseModel
            {
                ClientId = requestModel.ClientId,
                EmpId = requestModel.EmpId,
                IntType = requestModel.IntType,
                IntDate = requestModel.IntDate,
                Remarks = requestModel.Remarks
            };
            return interactionCard;
        }

        

        public async Task<InteractionDetailsModel> GetInteractionDetails(int id)
        {
            var interaction = await _interactionRepository.GetByIdAsync(id);
            var client = await _clientRepository.GetByIdAsync(interaction.ClientId);
            var employee = await _employeeRepository.GetByIdAsync(interaction.EmpId);
            var interactionDetails = new InteractionDetailsModel
            {
                Id = interaction.Id,
                ClientId = interaction.ClientId,
                EmpId = interaction.EmpId,
                ClientName = client.Name,
                EmpName = employee.Name,
                IntType = interaction.IntType,
                IntDate = interaction.IntDate,
                Remarks = interaction.Remarks
            };
            return interactionDetails;
        }

        public async Task<List<InteractionCardResponseModel>> GetInteractionsByClientId(int id)
        {
            var interactions = await _interactionRepository.GetInteractionsByClientId(id);
            var interactionCards = new List<InteractionCardResponseModel>();
            foreach (var interaction in interactions)
            {
                interactionCards.Add(new InteractionCardResponseModel
                {
                    ClientId = interaction.ClientId,
                    EmpId = interaction.EmpId,
                    IntType = interaction.IntType,
                    IntDate = interaction.IntDate,
                    Remarks = interaction.Remarks
                });
            }
            return interactionCards;
        }

        public async Task<List<InteractionCardResponseModel>> GetInteractionsByEmployeeId(int id)
        {
            var interactions = await _interactionRepository.GetInteractionsByEmployeeId(id);
            var interactionCards = new List<InteractionCardResponseModel>();
            foreach (var interaction in interactions)
            {
                interactionCards.Add(new InteractionCardResponseModel
                {
                    ClientId = interaction.ClientId,
                    EmpId = interaction.EmpId,
                    IntType = interaction.IntType,
                    IntDate = interaction.IntDate,
                    Remarks = interaction.Remarks
                });
            }
            return interactionCards;
        }

        public async Task<InteractionDetailsModel> UpdateInteraction(InteractionDetailsModel model)
        {
            var interaction = new Interaction
            {
                Id = model.Id,
                ClientId = model.ClientId,
                EmpId = model.EmpId,
                IntType = model.IntType,
                IntDate = model.IntDate,
                Remarks = model.Remarks
            };

            var updatedInteraction = await _interactionRepository.UpdateAsync(interaction);
            return null;
        }

        public async Task DeleteInteraction(int id)
        {
            var interaction = new Interaction
            {
                Id = id
            };
            await _interactionRepository.DeleteAsync(interaction);
        }
    }
}
