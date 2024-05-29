using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class MobileObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Mobile Notification of Iphone Stock..");
        }
    }
}
