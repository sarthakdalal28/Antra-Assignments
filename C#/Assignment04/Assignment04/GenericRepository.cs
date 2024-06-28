using Assignment04.Interface;

namespace Assignment04;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> _items = new List<T>();
    
    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public void Save()
    {
        
    }


    public IEnumerable<T> GetAll()
    {
        return _items;
    }

    public T GetById(int id)
    {
        foreach (T item in _items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return null;
    }
}