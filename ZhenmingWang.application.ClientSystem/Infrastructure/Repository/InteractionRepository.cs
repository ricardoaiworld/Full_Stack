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
    public class InteractionRepository : EfRepository<Interaction>, IInteractionRepository
    {
        public InteractionRepository(ClientSystemDbContext dbContext) : base(dbContext)
        {
        }

        public Task<Interaction> AddInteraction()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Interaction>> GetInteractionsByClientId(int id)
        {
            var interactions = await _dbContext.Interactions.Where(i => i.ClientId == id).ToListAsync();
            return interactions;

        }

        public async Task<List<Interaction>> GetInteractionsByEmployeeId(int id)
        {
            var interactions = await _dbContext.Interactions.Where(i => i.EmpId == id).ToListAsync();
            return interactions;
        }
    }
}
