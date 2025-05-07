using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using WpfTestApp.MVVM.Model;
using WpfTestApp.MVVM.Model.RP.Repo;


namespace WpfTestApp.MVVM.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly JsonItemRepo _itemRepo; //Initialize the jsonFileRepo

        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            _itemRepo = new JsonItemRepo("Items.txt");//Enable it to do stuff with the car text file.
            LoadItems();


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
            MessageBoxResult result = MessageBox.Show("Er du sikker på du vil slette denne genstand?", "PAS PÅ!", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                Items.Remove(SelectedItem);
            }
            
        }

        private void Save()
        {
            _itemRepo.SaveItems(Items.ToList());  // Convert ObservableCollection to List
        }
        private bool CanSave()
        {
            return true;
        }
        private void LoadItems()
        {
            var itemsFromFile = _itemRepo.GetAllItems(); // Get items from the repo
            Items.Clear(); // Clear current items, if any

            foreach (var item in itemsFromFile)  // Iterate through the items
            {
                Items.Add(item);  // Add each item to ObservableCollection
            }
        }
    }
}
