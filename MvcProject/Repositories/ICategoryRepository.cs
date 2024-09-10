﻿using Domain.Entities;
using Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
