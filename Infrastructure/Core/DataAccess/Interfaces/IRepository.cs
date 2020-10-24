﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Core.DataAccess.Interfaces {
    public interface IRepository<T> {
        IEnumerable<T> GetEntityQueryCollection();
    }
}
