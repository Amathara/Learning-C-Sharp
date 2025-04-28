using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTestApp.Model;

namespace WpfTestApp.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
       public ObservableCollection<Item> Items { get; set; }

        public MainWindowViewModel() 
        {
        
        }

        private Item _selectedItem;

        

        public Item SelectedItem
        {
            get {  return _selectedItem; }
            set { _selectedItem = value; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void 
    }
}
