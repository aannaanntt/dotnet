//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//     class ThtreadDemo
//    {

//        public static void func1()
//        {
//            for (int i = 0; i <= 50; i++)
//            {

//                Console.WriteLine("func1" + i);

//            }
//        }

//        public static void func2()
//        {
//            for (int i = 0; i <= 50; i++)
//            {

//                Console.WriteLine("func2" + i);

//                if (i == 23)
//                {
//                    Console.WriteLine("Thread is going to sleep now");
//                    Thread.Sleep(8000);
//                }

//            }
//        }

//        public static void func3()
//        {
//            for (int i = 0; i <= 50; i++)
//            {

//                Console.WriteLine("func3" + i);

//            }
//        }
//            static void Main(string[] args)
//        {
//            //Thread t = Thread.CurrentThread;
//            //t.Name = "Main";
//            //Console.WriteLine("current thread"+t.Name);

//            Thread t = new Thread(func1);
//            Thread t2 = new Thread(func2);
//            Thread t3 = new Thread(func3);
//            t.Start();
//            t2.Start();
//            t3.Start();
//        }

//    }
//}
