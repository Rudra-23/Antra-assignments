using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics;

public class GenericRepository<T> : IRepository<T>
{
    List<T> list;   
    public GenericRepository() 
    { 
        list = new List<T>();
    }
    public void Add(T item)
    {
        list.Add(item);
    }

    public IEnumerable<T> GetAll()
    {
        return list;
    }

    public T GetById(int id)
    {
        return (T)list[id];
    }

    public void Remove(T item)
    {
        list.Remove(item);   
    }

    public void Save()
    {
        return;
    }
}
