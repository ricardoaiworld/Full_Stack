using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IInteractionRepository : IAsyncRepository<Interaction>
    {
        Task<List<Interaction>> GetInteractionsByClientId(int id);
        Task<List<Interaction>> GetInteractionsByEmployeeId(int id);
        Task<Interaction> AddInteraction();

    }
}
