using System;

namespace MailSubscribers
{
    public class Subscriber
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Date { get; set;}

        public Subscriber(string name, string email, string date)
        {
            Name = name;
            Email = email;
            Date = date;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Email: {Email}, Дата подписки: {Date}";
        }
    }
}