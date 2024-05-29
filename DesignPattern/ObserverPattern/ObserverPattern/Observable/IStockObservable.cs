using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observable
{
    public interface IStockObservable
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
        public void SetData(int stock);
        public int GetData();
    }
}
