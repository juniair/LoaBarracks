using System;
using System.Collections.Generic;
using System.Text;
using LoaBarracks.Core.Models;
using LoaBarracks.Core.Exceptions;

namespace LoaBarracks.Core.Observer
{
    public class WeekRaidMonitor : IObserver<Item>
    {
        private IDisposable _unsubscriber;
        private Item _item;

        public WeekRaidMonitor(Item item)
        {
            _item = item;
        }

        public virtual void Subscribe(IObservable<Item> providor)
        {
            _unsubscriber = providor.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new ObserverErrorException("WeekRaidObserver", error);
        }

        public void OnNext(Item value)
        {
            if(_item.Type == value.Type)
            {
                _item.Price = value.Price;
            }
        }
    }
}
