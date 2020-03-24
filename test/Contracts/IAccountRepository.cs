using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Entities;
using test.Entities.Models;
using test.Repository;

namespace test.Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        public IEnumerable<Account> AccountsByOwner(Guid ownerId);
        PagedList<Account> GetAllOwners(Guid ownerId, AccountParameters ownerParameters);

    }
}