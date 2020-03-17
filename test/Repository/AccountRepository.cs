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
    }
}