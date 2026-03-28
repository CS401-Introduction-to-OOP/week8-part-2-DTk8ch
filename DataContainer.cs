using System.Collections.Generic;

namespace Variant3;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public long GetTotalSize()
    {
        long sum = 0;

        for (int i = 0; i < _items.Count; i++)
        {
            sum += _items[i].GetSize();
        }

        return sum;
    }
}
