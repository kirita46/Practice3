class Task2
{
    public static void Run()
    {
        LinkedList<bool> boolList = new LinkedList<bool>();
        boolList.AddLast(true);
        boolList.AddLast(false);
        boolList.AddLast(true);
        boolList.AddLast(false);
        boolList.AddLast(true);

        Console.WriteLine("Первая коллекция (LinkedList<bool>):");
        foreach (var item in boolList)
        {
            Console.WriteLine(item);
        }

        int n = 2;
        for (int i = 0; i < n && boolList.Count > 0; i++)
        {
            boolList.RemoveFirst();
        }

        Console.WriteLine($"\nПервая коллекция после удаления {n} элементов:");
        foreach (var item in boolList)
        {
            Console.WriteLine(item);
        }

        boolList.AddFirst(false);
        boolList.AddLast(true);
        LinkedListNode<bool> node = boolList.Find(true);
        if (node != null)
        {
            boolList.AddAfter(node, false);
        }

        Console.WriteLine("\nПервая коллекция после добавления элементов:");
        foreach (var item in boolList)
        {
            Console.WriteLine(item);
        }

        Dictionary<int, bool> boolDictionary = new Dictionary<int, bool>();
        int key = 0;
        foreach (var item in boolList)
        {
            boolDictionary.Add(key++, item);
        }

        Console.WriteLine("\nВторая коллекция (Dictionary<int, bool>):");
        foreach (var kvp in boolDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        Console.Write("\nВведите значение для поиска (true/false): ");
        bool searchValue = bool.Parse(Console.ReadLine());
        bool found = boolDictionary.ContainsValue(searchValue);

        Console.WriteLine($"\nСодержит ли вторая коллекция значение \"{searchValue}\"? {(found ? "Да" : "Нет")}");
    }
}
