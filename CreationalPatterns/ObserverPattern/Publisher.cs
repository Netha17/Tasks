using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Publisher
    {
        ArrayList subscribersList = null;
        string publisherName;
        public Publisher( string publisherName)
        {
          this.publisherName = publisherName;
            subscribersList = new ArrayList();
        }
        public void Subscribe(ISubscriber s)
        {
            subscribersList.Add(s);
        }
        public void Unsubscribe(ISubscriber s)
        {
            subscribersList.Remove(s);
        }
        public void NotifySubscribers(string product)
        {
            foreach(ISubscriber s in subscribersList)
            {
                s.update(product,publisherName);
            }
        }
        public void LaunchProduct(string productName)
        {
            NotifySubscribers(productName);
        }
    }
}
