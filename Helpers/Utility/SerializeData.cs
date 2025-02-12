using Helpers.Interface;
using Newtonsoft.Json;
using System.IO;

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
