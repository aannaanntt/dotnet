//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//     class ExceptionDemo
//    {
//        static void Main(string[] args)
//        {
//            //int num1 = int.Parse(Console.ReadLine());
//            //int num2 = int.Parse(Console.ReadLine());
//            //int res=0;
//            //try
//            //{
//            // res= num1 / num2;
//            //}
//            //catch (DivideByZeroException e) {
//            //    //Console.WriteLine(e.StackTrace);
//            //    Console.WriteLine("Cannot divide by 0");
//            //}
//            //Console.WriteLine("Division result is {0}",res);
//            //Console.WriteLine("Remaining statement 1");

//            //int[] arr = new int[3];



//            //try
//            //{
//            //    arr[0] = 1;
//            //    arr[1] = 2;
//            //    arr[2] = 3; 
//            //    arr[3] = 4;

//            //}
//            //catch(IndexOutOfRangeException ie)
//            //{
//            //    Console.WriteLine(ie.Message);
//            //}
//            //foreach (int i in arr) {

//            //    Console.WriteLine(i);
//            //}

//            //string name = null;
//            //try
//            //{
//            //    Console.WriteLine(name.Length);
//            //}
//            //catch (NullReferenceException nre)
//            //{
//            //    Console.WriteLine("String is null"+nre.Message);
//            //}

//            string number = Console.ReadLine();
//            int num = 0;
//            try
//            {
//             num = int.Parse(number);
//            }catch(FormatException fe)
//            {
//                Console.WriteLine(fe.Message);
//            }
//            Console.WriteLine("Number is"+num);
//        }
//    }
//}
