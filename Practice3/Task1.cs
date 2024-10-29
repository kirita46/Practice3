using System.Collections;

public class Task1
{
    public static void Run()
    {
        ArrayList list = new ArrayList();
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            list.Add(random.Next(1, 100));
        }

        list.Add("ExampleString");

        Console.WriteLine("Коллекция после добавления строки:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.Write("\nВведите значение для удаления: ");
        string userInput = Console.ReadLine();

        int.TryParse(userInput, out int number);

        // Удаляем элемент, если он найден.
        if (list.Contains(number))
        {
            list.Remove(number);
            Console.WriteLine($"\nЭлемент \"{number}\" удален из коллекции.");
        }
        if (list.Contains(userInput))
        {
            list.Remove(userInput);
            Console.WriteLine($"\nЭлемент \"{number}\" удален из коллекции.");
        }

        Console.WriteLine($"\nКоличество элементов в коллекции: {list.Count}");
        Console.WriteLine("Элементы коллекции:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.Write("\nВведите значение для поиска: ");
        userInput = Console.ReadLine();
        
        int.TryParse(userInput, out number);

        bool contains = list.Contains(number) || list.Contains(userInput);
        Console.WriteLine($"\nСодержит ли коллекция значение \"{userInput}\"? {(contains ? "Да" : "Нет")}");
    }
}
