using System.Collections.ObjectModel;
using System.Collections.Specialized;

public class Task4
{
    public static void Run()
    {
        ObservableCollection<Person> people = new ObservableCollection<Person>();
        people.CollectionChanged += OnCollectionChanged;

        Console.WriteLine("Добавление элементов в коллекцию:");
        people.Add(new Person("Alice", 30));
        people.Add(new Person("Bob", 25));
        people.Add(new Person("Charlie", 35));

        Console.WriteLine("\nУдаление элемента из коллекции:");
        people.RemoveAt(1); 

        Console.WriteLine("\nТекущая коллекция:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }

    private static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                Console.WriteLine("Элемент(ы) добавлен(ы):");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p);
                }
                break;

            case NotifyCollectionChangedAction.Remove:
                Console.WriteLine("Элемент(ы) удален(ы):");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p);
                }
                break;

            case NotifyCollectionChangedAction.Replace:
                Console.WriteLine("Элемент(ы) заменен(ы):");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine("Старый: " + p);
                }
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine("Новый: " + p);
                }
                break;

            case NotifyCollectionChangedAction.Move:
                Console.WriteLine("Элемент перемещен.");
                break;

            case NotifyCollectionChangedAction.Reset:
                Console.WriteLine("Коллекция сброшена.");
                break;
        }
    }
}
