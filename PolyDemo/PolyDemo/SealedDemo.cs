//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//   sealed class BaseClass
//    {
//        public void show1()
//        {
//            Console.WriteLine("Method of base class");
//        }

        
//    }
//    class DerivedClass { 
    
//        public void show2()
//        {
//            Console.WriteLine("Method of derived class");
//        }
    
//    }

//    class A
//    {
//        public virtual void Print()
//        {
//            Console.WriteLine("This is a method of sealed method demo");
//        }
//    }

//    class B : A
//    {
//        public sealed override void Print()
//        {
//            Console.WriteLine(" B This is a method of sealed method demo");
//        }
//    }
//    class C : B
//    {
//        //public override void Print()
//        //{
//        //    Console.WriteLine(" C This is a method of sealed method demo");
//        //}
//    }
//     class SealedDemo
//    {
//        static void Main(string[] args) { 
        
//            C c = new C();
//            c.Print();
         
//        }
//    }
//}
