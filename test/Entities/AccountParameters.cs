using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Entities
{
    public class AccountParameters : QueryStringParameters
    {
        public AccountParameters()
        {
            OrderBy = "DateCreated";
        }
    }
}
