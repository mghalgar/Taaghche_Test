﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taaghche.Domain.Models;

namespace Taaghche.Domain.Contracts.Providers
{
    public interface ICacheBookProvider
    {
        Task<BookModel> Get(int id);
        Task Set(int id,BookModel model);
    }
}
