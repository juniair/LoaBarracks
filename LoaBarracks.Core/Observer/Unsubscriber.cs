using System;
using System.Collections.Generic;
using System.Text;
using LoaBarracks.Core.Models;

namespace LoaBarracks.Core.Observer
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Item>> _observers;
        private IObserver<Item> _observer;
        bool _disposed = false;

        public Unsubscriber(List<IObserver<Item>> observers, IObserver<Item> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        #region Dispose Logic
        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
                _observers?.Remove(_observer);
            }

            // Free any unmanaged objects here.
            //
            _disposed = true;
        }

        ~Unsubscriber()
        {
            Dispose(false);
        } 
        #endregion

    }
}
