using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PushNotification.Models;


namespace PushNotification.ViewModels
{
    public class ItemViewModel: ItemViewModelBase, INotifyPropertyChanged
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        private int _checkedCount;
        public int CheckedCount
        {
            get => _checkedCount;
            set
            {
                _checkedCount = value;
                OnPropertyChanged();
            }
        }

        public ItemViewModel()
        {
            // Add some sample items
            Items.Add(new Item { Name = "Item 1" });
            Items.Add(new Item { Name = "Item 2" });
            Items.Add(new Item { Name = "Item 3" });

            // Subscribe to changes in the collection
            foreach (var item in Items)
            {
                item.PropertyChanged += Item_PropertyChanged;
            }
        }

        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Item.IsChecked))
            {
                UpdateCheckedCount();
            }
        }

        private void UpdateCheckedCount()
        {
            CheckedCount = Items.Count(item => item.IsChecked);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
