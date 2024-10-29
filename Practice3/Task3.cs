public class Task3
{
    public static void Run()
    {
        LinkedList<Person> personList = new LinkedList<Person>();
        personList.AddLast(new Person("Alice", 30));
        personList.AddLast(new Person("Bob", 25));
        personList.AddLast(new Person("Charlie", 35));
        personList.AddLast(new Person("Diana", 28));
        personList.AddLast(new Person("Eve", 22));

        Console.WriteLine("Первая коллекция (LinkedList<Person>):");
        foreach (var person in personList)
        {
            Console.WriteLine(person);
        }

        int n = 2;
        for (int i = 0; i < n && personList.Count > 0; i++)
        {
            personList.RemoveFirst();
        }

        Console.WriteLine($"\nПервая коллекция после удаления {n} элементов:");
        foreach (var person in personList)
        {
            Console.WriteLine(person);
        }

        personList.AddFirst(new Person("Frank", 40)); 
        personList.AddLast(new Person("Grace", 29)); 
        LinkedListNode<Person> node = personList.Find(new Person("Charlie", 35));
        if (node != null)
        {
            personList.AddAfter(node, new Person("Hank", 27)); 
        }
        
        Console.WriteLine("\nПервая коллекция после добавления элементов:");
        foreach (var person in personList)
        {
            Console.WriteLine(person);
        }
        
        Dictionary<int, Person> personDictionary = new Dictionary<int, Person>();
        int key = 0;
        foreach (var person in personList)
        {
            personDictionary.Add(key++, (Person)person.Clone());
        }

        Console.WriteLine("\nВторая коллекция (Dictionary<int, Person>):");
        foreach (var kvp in personDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // f) Находим во второй коллекции заданное значение.
        Console.Write("\nВведите имя для поиска: ");
        string searchName = Console.ReadLine();
        bool found = false;
        foreach (var kvp in personDictionary)
        {
            if (kvp.Value.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Найдено: Key: {kvp.Key}, Value: {kvp.Value}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"\nЧеловек с именем \"{searchName}\" не найден в коллекции.");
        }

        // Демонстрация сортировки с использованием IComparer
        var sortedList = new List<Person>(personList);
        sortedList.Sort();
        Console.WriteLine("\nОтсортированная коллекция по имени:");
        foreach (var person in sortedList)
        {
            Console.WriteLine(person);
        }
    }
}