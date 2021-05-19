using System;

namespace IItemDLL
{
    public interface IItem
    {
        int Id { get; }
        string ItemName { get; }
        double Amount { get; }

        void RemoveAmount(double amount);
        void AddAmount(double amount);
        void EditItem(string name);
    }
}
