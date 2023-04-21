using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Publisher
    {
        ArrayList subscribers = null;
        string name;
        public Publisher(string title)
        {
            this.name = title;
            subscribers = new ArrayList();
        }
        public void subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        public void NotifySubscribers(string productTitle)
        {
            foreach(ISubscriber s in subscribers)
            {
                s.update(productTitle);
            }
        }
        public void launchProduct(string title)
        {
            NotifySubscribers(title);
        }
        public void getSubscribers()
        {
            foreach(ISubscriber s in subscribers)
            {
                Console.WriteLine(s.ToString());
            }
        }

    }
}
