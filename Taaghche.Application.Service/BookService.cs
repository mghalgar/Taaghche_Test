using Microsoft.Extensions.Caching.Memory;
using System;
using System.Threading.Tasks;
using Taaghche.Application.Contracts;
using Taaghche.Domain.Contracts.Providers;
using Taaghche.Domain.Models;
using Taaghche.Domain.Services;

namespace Taaghche.Application.Service
{
    public class BookService : IBookService
    {
        private readonly ICacheBookProvider _cacheBookProvider;
        private readonly IBookProvider _bookProvider;
        private readonly IMemoryCache _memoryCache;

        public BookService(
            ICacheBookProvider cacheBookProvider,
            IBookProvider bookProvider,
            IMemoryCache memoryCache
            )
        {
            _cacheBookProvider = cacheBookProvider;
            _bookProvider = bookProvider;
            _memoryCache = memoryCache;
        }

        public Task<BookModel> Get(int id)
        {
            return new BookDataHandler().Get(id, _memoryCache, _cacheBookProvider, _bookProvider);
        }
    }
}
