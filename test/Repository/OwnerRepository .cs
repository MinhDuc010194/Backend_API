using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Contracts;
using test.Entities;
using test.Entities.Models;

namespace test.Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return FindAll()
                .OrderBy(ow => ow.Name)
                .ToList();
        }
    }
}