﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trevette_api.Domain.Models;

namespace trevette_api.Domain.Repositories
{
    public interface ISalesObjectRepository : IBaseRepository
    {
        Task<SalesObject[]> ListAsync();
        Task<SalesObject> GetByIdAsync(int id);
    }
}
