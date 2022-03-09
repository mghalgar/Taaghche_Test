using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Taaghche.Infrastructure.JsonTools
{
    public static class Serializer
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static string Serialize<T>(this T data) => JsonSerializer.Serialize(data,options);
        public static T DeSerialize<T>(this string json) => JsonSerializer.Deserialize<T>(json,options);
    }
}
