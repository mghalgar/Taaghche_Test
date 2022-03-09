using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Taaghche.Domain.Contracts.Providers;
using Taaghche.Domain.Models;
using Taaghche.Infrastructure.Contracts;
using Taaghche.Infrastructure.Providers.Common;

namespace Taaghche.Infrastructure.Providers
{
    public class BookProvider : IBookProvider
    {
        private readonly HttpRequestHandler _httpRequestHandler;
        private const string _apiUrl = "https://get.taaghche.com/v2/book";
        public BookProvider(HttpClient httpClient)
        {
            _httpRequestHandler = new HttpRequestHandler(httpClient);
        }

        public Task<BookModel> Get(int id)
        {
            var url = $"{_apiUrl}/{id}";
            return _httpRequestHandler.Get<BookModel>(url);
        }

    }
}
