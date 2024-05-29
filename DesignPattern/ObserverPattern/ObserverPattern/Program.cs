using ObserverPattern.Observable;
using ObserverPattern.Observer;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Design Notify me on iphone Amazon
            //Observer pattern: publisher subscriber
            //publisher: iphoneObservable , we haev stock
            //subscriber: observer -> clients getNotified on email/mobile

            IStockObservable stockObservable = new IphoneStockObservable();
            IObserver observer1 = new EmailObserver();
            IObserver observer2 = new MobileObserver();

            stockObservable.Add(observer1);
            stockObservable.Add(observer2);
            stockObservable.SetData(10);
            Console.ReadKey();
        }
    }
}
