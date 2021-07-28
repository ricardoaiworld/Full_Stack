using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IClientRepository : IAsyncRepository<Client>
    {
        Task<List<Client>> GetAllClients();
    }
}
