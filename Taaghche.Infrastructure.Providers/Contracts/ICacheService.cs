using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Taaghche.Infrastructure.Contracts
{
    public interface ICacheService
    {
        Task<T> Get<T>(object key);
        Task Set<T>(object key,T data);
    }
}
