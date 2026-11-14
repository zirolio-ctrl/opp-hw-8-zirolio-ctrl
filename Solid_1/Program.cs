using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    class Item { }

    class Order
    {
        private List<Item> itemList = new List<Item>();
        public List<Item> ItemList { get { return itemList; } set { itemList = value; } }

        public void AddItem(Item item) { /*...*/ }
        public void DeleteItem(Item item) { /*...*/ }
        public List<Item> GetItems() { /*...*/ }
        public int GetItemCount() { /*...*/ }
        public decimal CalculateTotalSum() { /*...*/ }
    }

    class OrderPrinter
    {
        public void PrintOrder(Order order) { /*...*/ }
        public void ShowOrder(Order order) { /*...*/ }
    }

    class OrderRepository
    {
        public Order Load(int id) { /*...*/ }
        public void Save(Order order) { /*...*/ }
        public void Update(Order order) { /*...*/ }
        public void Delete(Order order) { /*...*/ }
    }
}
