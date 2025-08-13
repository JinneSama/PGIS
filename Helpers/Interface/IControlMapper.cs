using System.Windows.Forms;

namespace Helpers.Interface
{
    public interface IControlMapper<T> where T : class
    {
        void MapToControls(T entity, params Control[] controlParents);
        void MapToEntity(T entity, Control controlParent);
    }
}
