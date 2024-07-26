//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{

//    class NewClass
//    {
//        public string str;
//        public int num;

//        public static NewClass operator + (NewClass obj1,NewClass obj2)
//        {
//            NewClass obj3 = new NewClass();
//            obj3.str = obj1.str +" "+ obj2.str;
//            obj3.num = obj1.num + obj2.num;
//            Console.WriteLine(obj3.str + obj3.num);
//            return obj3;
//        }


//    }
//     class OperatorOverDemo
//    {
//        static void Main(string[] args)
//        {
//            NewClass nc = new NewClass();
//            nc.str = "Anant";
//            nc.num = 12;

//            NewClass nc1 = new NewClass();
//            nc1.str = "Mishra";
//            nc1.num = 34;

//          NewClass nc3 = new NewClass();
//            nc3 = nc + nc1;

//            Console.WriteLine(nc3.str + ":"+ nc3.num);
//        }
//    }
//}
