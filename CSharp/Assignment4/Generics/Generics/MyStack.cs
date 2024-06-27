using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics;

public class MyStack<T> where T: class
{
    private Stack<T> stack;

    public MyStack() { 
        this.stack = new Stack<T>();
    }

    public int Count()
    {
        return this.stack.Count;
    }

    public T Pop()
    {
        if (this.stack.Count == 0) throw new Exception("Out Of Bounds");
        return this.stack.Pop();
    }

    public void Push(T item) 
    { 
       this.stack.Push(item);
    }
}
