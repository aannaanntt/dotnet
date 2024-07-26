//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{   //delegate and method return tuye/signature should be same
//    //this is used when we want to encapsulate the method
//    public delegate void Calculation(int a, int b);
//    //public delegate void show_Delegate();
//    //public delegate void Calculation2(int num);
//     class DelegatesDemo
//{

//        public static void Square(int num)
//        {
//            int square = num * num;
//            Console.WriteLine(square);
//        }

//        public static void Cube(int num)
//        {
//            int cube = num * num * num;
//            Console.WriteLine(cube);
//        }
//        public static void Show()
//        {
//            Console.WriteLine("This is a show method");
//        }

//       public static void Addition(int a,int b)
//        {
//            int result = a + b;
//            Console.WriteLine("Addition result is {0}",result);
//        }

//        public static void Subtraction(int a, int b)
//        {
//            int result = a - b;
//            Console.WriteLine("Subtraction result is {0}", result);
//        }


//        public static void Multiplication(int a, int b)
//        {
//            int result = a * b;
            
            
//            Console.WriteLine("Multiplication result is {0}", result);
//        }


//        public static void Division(int a, int b)
//        {
//            int result = a / b;
//          Console.WriteLine("division result is {0}", result);
//        }
//        static void Main(string[] args) {

//            Calculation obj = new Calculation(Addition);
            
//            obj += Subtraction;
//            obj += Multiplication;
//            obj -=  Division;
//            obj.Invoke(200, 20);

          


//        }
//   }
//}
