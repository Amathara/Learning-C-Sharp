using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfTestApp.MVVM.Model;

namespace WpfTestApp.MVVM.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
       public ObservableCollection<Item> Items { get; set; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item("Book 1", "B0001", 4));
            Items.Add(new Item("Book 2", "B0002", 6));
            Items.Add(new Item("Boardgame 1", "BG0001", 10));
        }


        private Item _selectedItem;

        

        public Item SelectedItem
        {
            get {  return _selectedItem; }
            set 
            { 
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

      
    }
}
