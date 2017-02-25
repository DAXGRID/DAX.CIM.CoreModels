using Newtonsoft.Json;

namespace DAX.CIM.PhysicalNetworkModel.Protobuf.Tests
{
    public static class JsonEs
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                TypeNameHandling=TypeNameHandling.All,
                Formatting=Formatting.Indented
            });
        }
    }
}