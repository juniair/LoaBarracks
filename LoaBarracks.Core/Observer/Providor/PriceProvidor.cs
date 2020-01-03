using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoaBarracks.Core.Enums;
using LoaBarracks.Core.Factory;
using LoaBarracks.Core.Models;

namespace LoaBarracks.Core.Observer
{
    public class PriceProvidor : IObservable<Item>
    {
        private List<IObserver<Item>> _observers = new List<IObserver<Item>>();
        private IFactory _itemFactory;

        public PriceProvidor(IFactory itemFactory)
        {
            _itemFactory = itemFactory;
        }

        public IDisposable Subscribe(IObserver<Item> observer)
        {
            if (!_observers.Contains(observer)) 
            {
                _observers.Add(observer);
            }

            return new Unsubscriber(_observers, observer);
        }

        public  void UpdateTicketPrice(double price, ItemType itemType)
        {
            var item = _itemFactory.MakeItem(itemType);
            item.Price = price;
            foreach (var observer in _observers)
            {
                observer.OnNext(item);
            }
        }
    }
}
