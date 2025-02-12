using System.ComponentModel;
using System.Linq;

namespace Helpers.Enum
{
    public class EnumHelper
    {
        public static string GetEnumDescription(System.Enum value)
        {
            if (value == null) return null;
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
