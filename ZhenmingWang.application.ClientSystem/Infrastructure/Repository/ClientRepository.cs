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
    public class ClientRepository : EfRepository<Client>, IClientRepository
    {
        public ClientRepository(ClientSystemDbContext dbContext) : base(dbContext)
        {
        }

        

        public async Task<List<Client>> GetAllClients()
        {
            var clients = await _dbContext.Clients.OrderBy(c => c.Name).ToListAsync();
            return clients;
        }

    
    }
}
