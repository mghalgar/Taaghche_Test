using System;
using System.Threading.Tasks;
using Taaghche.Infrastructure.Contracts;
using StackExchange.Redis;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using Moq;
using Taaghche.Infrastructure.JsonTools;

namespace Taaghche.Infrastructure.Redis
{
    public class RedisService : ICacheService
    {
        private IConnectionMultiplexer _redis;


        public RedisService(IConfiguration _config)
        {
            string endpoint = _config["RedisEndpoint"];

            //try
            //{
            //    Connect(endpoint);
            //}
            //catch (Exception ex)
            //{

            //}

            var mockMultiplexer = new Mock<IConnectionMultiplexer>();

            mockMultiplexer.Setup(_ => _.IsConnected).Returns(false);

            var mockDatabase = new Mock<IDatabase>();

            mockMultiplexer
                .Setup(_ => _.GetDatabase(It.IsAny<int>(), It.IsAny<object>()))
                .Returns(mockDatabase.Object);

            _redis = mockMultiplexer.Object;

        }
        private void Connect(string endpoint)
        {
            _redis = ConnectionMultiplexer.Connect(endpoint);
        }
        private IDatabase GetDatabase()
        {
            var asyncState = new object();
            return _redis.GetDatabase(0, asyncState);
        }
        public async Task<T> Get<T>(object key)
        {
            var result = await GetDatabase().StringGetAsync(key.ToString());

            var strResult = result.ToString();

            if (strResult == null)
                return default(T);

            return strResult.DeSerialize<T>();
        }

        public Task Set<T>(object key, T data)
        {
            var strData = data.Serialize();
            return GetDatabase().StringSetAsync(key.ToString(), strData);
        }

    }

}
