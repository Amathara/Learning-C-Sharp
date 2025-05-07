using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp.MVVM.Model.RP.IRepo
{
    interface IItemRepo
    {
        internal interface IItemRepo
        {
            List<Item> GetAllItems();
            void AddItem(Item item);
            void DeleteItem(int id);
        }


    }
}
