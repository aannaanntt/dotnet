//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{

//    class Example<T>
//    {
//        T box;

//        public T Box {
//            get
//            {
//                return this.box;
//            }
//            set
//            {

//                this.box = value;
//            } 
//        }
//        //public Example(T a)
//        //{
//        //    this.box = a;
//        //}

//        //public T getBox()
//        //{
//        //    return this.box;
//        //}
//    }
//     class GenClassDemo
//    {
//        static void Main(string[] args)
//        {
//            //Example<int> ex = new Example<int>(20);
//            //Example<string> exStr = new Example<string>("Anant");
//            //Console.WriteLine(ex.getBox());

//            Example<int> e = new Example<int>();
//            e.Box = 1;
//            Console.WriteLine(e.Box);
//        }
//    }
//}
