using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern
{
    public sealed class EagerLoadingSingleton
    {
        private static int counter = 0;
        private static readonly EagerLoadingSingleton instance = new EagerLoadingSingleton();
        public static EagerLoadingSingleton GetInstance { get { return instance; } }
        private EagerLoadingSingleton()
        {
            counter++;
            Console.WriteLine("Counter Initialized " + counter);
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
