using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace TemplateSelectorUno.Shared.Common.TemplateSelectors
{
    [ContentProperty(Name = "Templates")]
    public class StringKeyTemplateSelector : DataTemplateSelector
    {
        public StringKeyTemplateSelectorCollection Templates { get; set; } = new StringKeyTemplateSelectorCollection();

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {

            string keyStr = item as string;

            if (keyStr != null)
            {
                var titem = Templates.FirstOrDefault(x => x.TemplateKey == keyStr);

                return titem?.DataTemplate;
            }

            if (Templates != null && Templates.Any())
            {
                return (Templates.FirstOrDefault(x => x.IsDefaultTemplate) ?? Templates.FirstOrDefault())?.DataTemplate;
            }

            return null;
        }
    }
}