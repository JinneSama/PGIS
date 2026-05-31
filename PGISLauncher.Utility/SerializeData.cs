using Newtonsoft.Json;
using PGISLauncher.Interfaces;

namespace Helpers.Utility
{
    public class SerializeData : ISerializeData
    {
        public string Serialize(object data)
        {
            string serialized = JsonConvert.SerializeObject(data);
            return serialized;
        }
    }
}
