using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrekshyaMaui.ViewModels
{
    public class ExpanderViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public ExpanderViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Item 1", Description = "Hello My name is Prekshya" },
                new Item { Name = "Item 2", Description = "Hello My name is Shreya" },
                new Item { Name = "Item 3", Description = "Hello My name is Sijan" },
            };
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

