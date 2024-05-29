using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    public class IphoneStockObservable : IStockObservable
    {
        public List<IObserver> Observers = new List<IObserver>();
        public int StockCount = 0;
        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public int GetData()
        {
            return StockCount;
        }

        public void Notify()
        {
            foreach(IObserver observer in Observers)
            {
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void SetData(int newStock)
        {
            if (StockCount == 0)
                Notify();

            StockCount += newStock;
        }
    }
}
