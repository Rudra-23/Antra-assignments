namespace Generics;

public class Program
{
    static void Main(string[] args)
    {
        /*
         Question 1: Stack
         */
        Console.WriteLine("\nQuestion 1: ");
        MyStack<string> stackString = new MyStack<string>();
        stackString.Push("Hello");
        stackString.Push("World");
        Console.WriteLine(stackString.Pop());
        Console.WriteLine(stackString.Count());

        /*
         Question 2: Lists
         */
        Console.WriteLine("\nQuestion 2: ");
        MyList<int> myList = new MyList<int>();

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        int removedItem = myList.Remove(1);

        Console.WriteLine($"Contains 10: {myList.Contains(10)} (Expected: True)");
        Console.WriteLine($"Contains 20: {myList.Contains(20)} (Expected: False)");

        myList.InsertAt(25, 1);
        Console.WriteLine($"Element at index 1: {myList.Find(1)} (Expected: 25)");

        myList.DeleteAt(0);
        Console.WriteLine($"Delete element at index 0: {myList.Find(0)} (Expected: 25)");

        Console.WriteLine($"Element at index 0: {myList.Find(0)} (Expected: 25)");
        Console.WriteLine($"Element at index 1: {myList.Find(1)} (Expected: 30)");
        myList.Clear();

        /* Question 3: CRUD */
        Console.WriteLine("\nQuestion 3: ");
        GenericRepository<Employee> EmpRepository = new GenericRepository<Employee>();

        EmpRepository.Add(new Employee(1, "A", 27));
        EmpRepository.Add(new Employee(2, "B", 23));
        EmpRepository.Add(new Employee(3, "C", 28));

        Console.WriteLine("Items after adding:");
        foreach (var item in EmpRepository.GetAll())
        {
            Console.WriteLine(item);
        }

        int idToGet = 1;
        Employee itemById = EmpRepository.GetById(idToGet);
        Console.WriteLine($"\nItem at index {idToGet}: {itemById.ToString()} (Expected: ID: 2)");

        Employee itemToRemove = EmpRepository.GetById(2);
        EmpRepository.Remove(itemToRemove);
        Console.WriteLine($"\nItems after removing {itemToRemove}:");
        foreach (var item in EmpRepository.GetAll())
        {
            Console.WriteLine(item);
        }

        EmpRepository.Save();
    }
}
