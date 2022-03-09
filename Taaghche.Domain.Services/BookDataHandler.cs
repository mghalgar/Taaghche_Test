using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Taaghche.Domain.Contracts.Providers;
using Taaghche.Domain.Models;

namespace Taaghche.Domain.Services
{
    public class BookDataHandler
    {
        public async Task<BookModel> Get(int bookId, IMemoryCache memoryCache, ICacheBookProvider cacheBookProvider, IBookProvider bookProvider)
        {
            BookModel memoryCacheResult = null;
            if (memoryCache.TryGetValue<BookModel>(bookId, out memoryCacheResult))
                return memoryCacheResult;

            var cacheResult = await cacheBookProvider.Get(bookId);
            if (cacheResult != null)
                return cacheResult;


            var result = await bookProvider.Get(bookId);
            if (result == null)
                return null;

            await cacheBookProvider.Set(bookId, result);


            memoryCache.Set(bookId, result,TimeSpan.FromMinutes(5));

            return result;
        }
    }
}
