using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Contracts;
using test.Entities;
using test.Entities.Models;

namespace test.Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }
        public PagedList<Account> GetAllOwners(Guid ownerId,AccountParameters ownerParameters)
        {
            return PagedList<Account>.ToPagedList(FindAll().Where(ow => ow.OwnerId == ownerId),
                    ownerParameters.PageNumber,
                    ownerParameters.PageSize);
        }
    }
}