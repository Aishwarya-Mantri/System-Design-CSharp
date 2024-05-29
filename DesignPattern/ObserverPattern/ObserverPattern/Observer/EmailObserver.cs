using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class EmailObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Email Notification of Iphone Stock..");

        }
    }
}
