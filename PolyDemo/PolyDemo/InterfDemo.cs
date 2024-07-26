//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//    interface IEmployee
//    {
//        void show();
//    }

//    interface I1
//    {
//        void print();
//    }
//    interface I2
//    {
//        void print1();
//    }

//    interface I3 :I1,I2
//    {
//        void print2();
//    }


//    class PartTimeEmp : IEmployee
//    {
//        public void show()
//        {
//            Console.WriteLine("I am showing");

//        }
//        class InterfDemo : I3
//        {
//            static void Main(string[] args)
//            {
//                PartTimeEmp emp = new PartTimeEmp();
//                emp.show();

//                InterfDemo id = new InterfDemo();
//                id.print();

//                I2 i = new InterfDemo();
//                i.print1();
//            }

//            public void print2()
//            {
//                Console.WriteLine("Method of I3");
//            }
//            public void print()
//            {
//                Console.WriteLine("Method of I2");
//            }
//            public void print1()
//            {
//                Console.WriteLine("Method of I1");
//            }
//        }
//    }
//}

