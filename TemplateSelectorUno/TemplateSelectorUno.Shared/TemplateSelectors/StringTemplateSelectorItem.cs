using System;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Markup;

namespace TemplateSelectorUno.Shared.Common.TemplateSelectors
{
    [ContentProperty(Name = "DataTemplate")]
    public class StringTemplateSelectorItem
    {
        public string TemplateKey { get; set; }
        public DataTemplate DataTemplate { get; set; }
        public bool IsDefaultTemplate { get; set; }
    }
}