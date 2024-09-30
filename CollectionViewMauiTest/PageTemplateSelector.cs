using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewMauiTest
{
    public class PageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Page0 { get; set; }
        public DataTemplate Page1 { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (((AbstractIndexPage)item).Index)
            {
                case 0: return Page0;
                case 1: return Page1;
                default: return Page0;
            }
        }
    }
    public class AbstractIndexPage
    {
        public int Index { get; set; }
    }
}
