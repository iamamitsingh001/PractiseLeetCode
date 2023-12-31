using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern
{
    public sealed class LazyLoadingSingleton
    {
        private static int counter = 0;
        private static readonly Lazy<LazyLoadingSingleton> instance = new Lazy<LazyLoadingSingleton>(()=> new LazyLoadingSingleton());
        public static LazyLoadingSingleton GetInstance
        {
            get { return instance.Value; }
        }
        private LazyLoadingSingleton()
        {
            counter++;
            Console.WriteLine("Counter Increased " + counter);
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
