#region Q2
namespace advanced1;

public class Container<T>
{
    private readonly List<T> _list = [];
    public void Add(T item)
    {
        _list.Add(item);
    }
    public T Get()
    {
        foreach (T item in _list)
        {
            return item;
        }
        return default;
    }
}

#endregion