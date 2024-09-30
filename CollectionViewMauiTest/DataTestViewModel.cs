using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewMauiTest
{
    public class DataTestViewModel
    {
        public ObservableCollection<DataTest> Items { get; set; } = new ObservableCollection<DataTest>();
        public DataTestViewModel()
        {
            Items.Add(new DataTest() { Name = "random text"});
            Items.Add(new DataTest() { Name = "random text"});
            Items.Add(new DataTest() { Name = "random text"});
            Items.Add(new DataTest() { Name = "random text"});
        }
    }
    public class DataTest()
    {
        public string Name { get; set; }
    }
}

