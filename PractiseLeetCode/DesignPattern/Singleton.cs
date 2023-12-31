using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DesignPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        private static Singleton instance = null;
        public static Singleton getInstance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Instance Counter " + counter);
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //Program.cs invoke
        //Parallel.Invoke(
        //        () => C1(),
        //        () => C2(),
        //        () => C3()
        //        );
        //    Console.ReadLine();

        //private static Singleton C3()
        //{
        //    LazyLoadingSingleton fromNew = LazyLoadingSingleton.GetInstance;
        //    fromNew.PrintMessage("Pihu Singh");
        //    EagerLoadingSingleton fromst = EagerLoadingSingleton.GetInstance;
        //    fromst.PrintMessage("Pihu Singh");
        //    Singleton fromStudent = Singleton.getInstance;
        //    fromStudent.PrintMessage("Pihu Singh");
        //    return fromStudent;
        //}

        //private static Singleton C2()
        //{
        //    LazyLoadingSingleton fromNew = LazyLoadingSingleton.GetInstance;
        //    fromNew.PrintMessage("Supriya Singh");
        //    EagerLoadingSingleton fromst = EagerLoadingSingleton.GetInstance;
        //    fromst.PrintMessage("Supriya Singh");
        //    Singleton fromEmployee2 = Singleton.getInstance;
        //    fromEmployee2.PrintMessage("Supriya Singh");
        //    return fromEmployee2;
        //}

        //private static Singleton C1()
        //{
        //    LazyLoadingSingleton fromNew = LazyLoadingSingleton.GetInstance;
        //    fromNew.PrintMessage("Amit Singh");
        //    EagerLoadingSingleton fromst = EagerLoadingSingleton.GetInstance;
        //    fromst.PrintMessage("Amit Singh");
        //    Singleton fromEmployee = Singleton.getInstance;
        //    fromEmployee.PrintMessage("Amit Singh");
        //    return fromEmployee;
        //}
    }
}
