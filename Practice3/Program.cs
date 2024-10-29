
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите задание для запуска:");
            Console.WriteLine("1. Задание 1");
            Console.WriteLine("2. Задание 2");
            Console.WriteLine("3. Задание 3");
            Console.WriteLine("4. Задание 4");
            Console.WriteLine("0. Выход");
            Console.Write("Введите номер задания: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "4":
                    Task4.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите задание от 1 до 4 или 0 для выхода.");
                    break;
            }

            Console.WriteLine();
        }
    }
}