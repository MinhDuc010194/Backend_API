using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Entities.Models;

namespace test.Contracts
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        IEnumerable<Owner> GetAllOwners();
    }
}