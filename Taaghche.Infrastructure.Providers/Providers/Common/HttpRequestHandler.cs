using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Taaghche.Infrastructure.JsonTools;

namespace Taaghche.Infrastructure.Providers.Common
{
    public class HttpRequestHandler
    {
        private readonly HttpClient _httpClient;

        public HttpRequestHandler(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> Get<T>(string url)
        {
            var result = await _httpClient.GetAsync(url);
            return await Prepare<T>(result);
        }
        private async Task<T> Prepare<T>(HttpResponseMessage response)
        {
            var strResult = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(strResult);

            response.Dispose();

            return strResult.DeSerialize<T>();
        }
    }
}
