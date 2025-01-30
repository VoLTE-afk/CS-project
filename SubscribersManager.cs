using System.Collections.Generic;

namespace MailSubscribers
{
    public class SubscribersManager
    {
        private List<Subscriber> _subscribers = new List<Subscriber>();

        public void AddSubscriber(Subscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(string email)
        {
            var subscriberToRemove = FindSubscriberByEmail(email);
            if (subscriberToRemove != null)
                _subscribers.Remove(subscriberToRemove);
            else
                Console.WriteLine($"Подписчик с email '{email}' не найден.");
        }

        public Subscriber FindSubscriberByEmail(string email)
        {
            return _subscribers.Find(s => s.Email == email);
        }

        public void DisplayAllSubscribers()
        {
            foreach (var subscriber in _subscribers)
                Console.WriteLine(subscriber.ToString());
        }
    }
}