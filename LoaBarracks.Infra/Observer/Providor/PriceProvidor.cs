using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoaBarracks.Infra.Enums;
using LoaBarracks.Infra.Models;

namespace LoaBarracks.Infra.Observer
{
    public class PriceProvidor : IObservable<Item>
    {
        private List<IObserver<Item>> _observers = new List<IObserver<Item>>();
        
        public IDisposable Subscribe(IObserver<Item> observer)
        {
            if (!_observers.Contains(observer)) 
            {
                _observers.Add(observer);
            }

            return new Unsubscriber(_observers, observer);
        }

        public  void UpdateTicketPrice(double price, ItemType type)
        {
            var item = new Item
            {
                Price = price,
                Type = type
            };
            foreach (var observer in _observers)
            {
                observer.OnNext(item);
            }
        }
    }
}
