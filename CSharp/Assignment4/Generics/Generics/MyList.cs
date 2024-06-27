using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics;

public class MyList<T> where T: struct
{
    private List<T> list;

    public MyList() 
    {
        this.list = new List<T>();
    }

    public void Add(T item)
    {
        this.list.Add(item);
    }

    public T Remove(int index) 
    { 
        if(index < 0 || index >= list.Count) throw new IndexOutOfRangeException();
        T item = this.list[index];
        this.list.RemoveAt(index);
        return item;
    }

    public bool Contains(T element) { return this.list.Contains(element);}
    public void Clear() { this.list.Clear(); }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException();
        this.list.Insert(index, element);
    }

    public void DeleteAt(int index) 
    {
        if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException();
        this.list.RemoveAt(index);
    }
    public T Find(int index)
    {
        if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException();
        return list[index];
    }
}
