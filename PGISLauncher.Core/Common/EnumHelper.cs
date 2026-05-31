using System.ComponentModel;
using System.Linq;

namespace PGISLauncher.Core.Common
{
    public class EnumHelper
    {
        public string GetEnumDescription(System.Enum value)
        {
            if (value == null) return null;
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
