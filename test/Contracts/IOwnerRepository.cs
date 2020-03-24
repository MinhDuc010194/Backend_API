using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Entities;
using test.Entities.Models;
using test.Repository;

namespace test.Contracts
{
    public interface IOwnerRepository : IRepositoryBase<Owner>
    {
        PagedList<Owner> GetAllOwners(OwnerParameters ownerParameters);
        PagedList<Owner> GetOwners(OwnerParameters ownerParameters);

        Owner GetOwnerById(Guid ownerId);

        Owner GetOwnerWithDetails(Guid ownerId);

        void CreateOwner(Owner owner);

        void UpdateOwner(Owner owner);

        void DeleteOwner(Owner owner);
    }
}