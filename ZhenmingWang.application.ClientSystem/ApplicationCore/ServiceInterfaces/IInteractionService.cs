using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IInteractionService
    {
        Task<List<InteractionCardResponseModel>> GetInteractionsByClientId(int id);
        Task<List<InteractionCardResponseModel>> GetInteractionsByEmployeeId(int id);
        Task<InteractionCardResponseModel> AddNewInteraction(InteractionAddRequestModel requestModel);
        Task<InteractionDetailsModel> GetInteractionDetails(int id);
        Task<InteractionDetailsModel> UpdateInteraction(InteractionDetailsModel model);
        Task DeleteInteraction(int id);
    }
}
