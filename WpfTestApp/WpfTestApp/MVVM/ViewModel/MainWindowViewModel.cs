using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WpfTestApp.MVVM.Model;

namespace WpfTestApp.MVVM.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
        }


        private Item _selectedItem;



        public Item SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Id = 0000,
                Name = "Navn",
                Condition = 0,
                NeedsApproval = 0,
                InWarehouse = 0
            });
           
        }

        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }

        private void Save()
        {
            //save to file/db
        }
        private bool CanSave()
        {
            return true;
        }
    }
}
