class Item
{
}

class Order
{
    private List<Item> itemList = new List<Item>();

    public void AddItem(Item item) => itemList.Add(item);

    public void DeleteItem(Item item) => itemList.Remove(item);

    public int GetItemCount() => itemList.Count;

    public double CalculateTotalSum()
    {
        return 0;
    }
}

class OrderPrinter
{
    public void PrintOrder(Order order)
    {
    }
}

class OrderRepository
{
    public void Save(Order order)
    {
    }

    public Order Load()
    {
        return new Order();
    }

    public void Delete(Order order)
    {
    }
}