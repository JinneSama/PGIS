using DevExpress.XtraEditors;
using Helpers.Interface;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Helpers.Utility
{
    public class ControlMapper<T> : IControlMapper<T> where T : class
    {
        public void MapToControls(T entity, Control controlParent)
        {
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var control = FindControlByPropertyName(controlParent, property.Name);
                if (control == null) continue;
                SetValue(property.GetValue(entity), control);
            }
        }
        private Control FindControlByPropertyName(Control parent, string propertyName)
        {
            return parent.Controls.Cast<Control>()
                .FirstOrDefault(ctrl => ctrl.Name == $"txt{propertyName}" || ctrl.Name == $"lbl{propertyName}"  || ctrl.Name == $"de{propertyName}");
        }

        public void SetValue(object value , Control control)
        {
            if (control is DateEdit dateEdit)
            {
                if (dateEdit == null) dateEdit.EditValue = null;
                else dateEdit.DateTime = (DateTime)value;
                return;
            }
            if (control is TextEdit textBox)
            {
                textBox.Text = value?.ToString() ?? string.Empty;
            }

            if (control is LabelControl label)
            {
                label.Text = value?.ToString() ?? string.Empty;
            }
        }

        public void MapToEntity(T entity, Control controlParent)
        {
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var control = FindControlByPropertyName(controlParent , property.Name);
                if (control == null) continue;
                SetPropertyValue(property, control, entity);
            }
        }

        private void SetPropertyValue(PropertyInfo property, Control control, T entity)
        {
            if (control is DateEdit dateEdit)
            {
                DateTime? timeValue = dateEdit.DateTime;
                if (!(dateEdit.EditValue == null))
                {
                    property.SetValue(entity, timeValue);
                }
                return;
            }

            if (control is TextEdit textBox)
            {
                string textValue = textBox.Text;
                if (!string.IsNullOrEmpty(textValue))
                {
                    var convertedValue = Convert.ChangeType(textValue, property.PropertyType);
                    property.SetValue(entity, convertedValue);
                }
            }
        }
    }
}
