using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IClientService
    {
        Task<List<ClientCardResponseModel>> GetAllClients();

        Task<ClientCardResponseModel> AddNewClient(ClientAddRequestModel requestModel);

        Task<ClientDetailsModel> GetClientDetails(int id);

        Task<ClientDetailsModel> UpdateClient(ClientDetailsModel model);

        Task DeleteClient(int id);
    }
}
