using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Entities.Models;

namespace test.Contracts
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        public IEnumerable<Account> AccountsByOwner(Guid ownerId);
    }
}