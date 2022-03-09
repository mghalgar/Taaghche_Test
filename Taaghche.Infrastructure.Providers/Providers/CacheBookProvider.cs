using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taaghche.Domain.Contracts.Providers;
using Taaghche.Domain.Models;
using Taaghche.Infrastructure.Contracts;

namespace Taaghche.Infrastructure.Providers
{
    public class CacheBookProvider : ICacheBookProvider
    {
        private readonly ICacheService _cacheService;
        public CacheBookProvider(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public Task<BookModel> Get(int id)
        {
            return _cacheService.Get<BookModel>(id);
        }

        public Task Set(int id,BookModel model)
        {
            return _cacheService.Set(id, model);
        }
    }
}
