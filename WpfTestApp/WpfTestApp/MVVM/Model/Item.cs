using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp.MVVM.Model
{
    public enum NeedsApproval
    {
        Ja,
        Nej
    }
    public enum InWarehouse
    {
        Ja,
        Nej
    }
    public enum Condition
    {
        Ny,
        God,
        Brugt,
        Ødelagt
    }
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Condition _condition; // Backing field
        public Condition Condition
        {
            get { return _condition; } // Return the backing field
            set
            {
                if (!Enum.IsDefined(typeof(Condition), value))
                {
                    throw new ArgumentException("Invalid value for Condition.");
                }
                _condition = value; // Assign to the backing field
            }
        }
        public NeedsApproval _needsApproval; // Backing field
        public NeedsApproval NeedsApproval
        {
            get { return _needsApproval; } // Return the backing field
            set
            {
                if (!Enum.IsDefined(typeof(NeedsApproval), value))
                {
                    throw new ArgumentException("Invalid value for NeedsApproval.");
                }
                _needsApproval = value; // Assign to the backing field
            }
        }
        public InWarehouse _inWarehouse; // Backing field
        public InWarehouse InWarehouse
        {
            get { return _inWarehouse; } // Return the backing field
            set
            {
                if (!Enum.IsDefined(typeof(InWarehouse), value))
                {
                    throw new ArgumentException("Invalid value for IsHome.");
                }
                _inWarehouse = value; // Assign to the backing field
            }
        }


        public Item() { }
        
        public Item(int id, string name, Condition condition, NeedsApproval needsApproval, InWarehouse inWarehouse)
        {
            Id = id;
            Name = name;
            Condition = condition;
            NeedsApproval = needsApproval;
            InWarehouse = inWarehouse;
        }
    }
}
