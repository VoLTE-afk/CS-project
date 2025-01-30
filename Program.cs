using System;

namespace MailSubscribers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание менеджера подписчиков
            var manager = new SubscribersManager();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Добавить подписчика");
                Console.WriteLine("2. Показать всех подписчиков");
                Console.WriteLine("3. Найти подписчика по email");
                Console.WriteLine("4. Удалить подписчика по email");
                Console.WriteLine("5. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": // Добавить юзера
                        Console.WriteLine("Введите имя подписчика (или 'exit' для выхода):");
                        string name = Console.ReadLine();

                        if (name.ToLower() == "exit") break;

                        Console.WriteLine("Введите email подписчика:");
                        string email = Console.ReadLine();

                        Console.WriteLine("Введите дату подписки (дд.мм.гггг):");
                        string date = Console.ReadLine();

                        manager.AddSubscriber(new Subscriber($"{name}", $"{email}", $"{date}"));
                        Console.WriteLine("Подписчик добавлен!\n");
                        break;
                    case "2": // Отобразить весь список
                        Console.WriteLine("Список подписчиков:");
                        manager.DisplayAllSubscribers();
                        break;
                    case "3": // найти по почте

                        Console.WriteLine("Введите почту подписчика (example@exm.ru):");
                        string uemail = Console.ReadLine();

                        var foundSubscriber = manager.FindSubscriberByEmail(uemail);
                        if (foundSubscriber != null)
                            Console.WriteLine($"Найденный подписчик: \nИмя: {foundSubscriber.Name}\nПочта: {foundSubscriber.Email}\nДата подписки: {foundSubscriber.Date}");
                        else
                            Console.WriteLine($"Подписчик с email '{uemail}' не найден.");
                        break;
                    case "4": // удалить пользователя
                        Console.WriteLine("Введите почту подписчика (example@exm.ru):");
                        string delEmail = Console.ReadLine();

                        manager.RemoveSubscriber(delEmail);
                        Console.WriteLine($"\nПодписчик с email '{delEmail}' был удален.");

                        break;
                    case "5":
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
                Console.ReadKey();
            }
        }
    }
}
