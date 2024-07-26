//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//    class Employee
//    {
//        private int[] Age = new int[3];

//        public int this[int index]
//        {
//            set
//            {
//                if (index <= Age.Length && index >=0)
//                {
//                    if (value <= 0)
//                    {
//                        Console.WriteLine("Age cant be negative");
//                    }
//                    else
//                    {
//                        Age[index] = value;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid index");
//                }
                
//            }
//            get {

//                return Age[index];
//            }
          
//        }   


//        public int this[int index,int i]
//        { 
//            set {
//                Age[index] = value + i; 
//            }
//            get { return Age[index]; }
//        }
//    }
//     class IndexerDemo
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee();
         
//            employee[0,1] =10;
           
//            Console.WriteLine(employee[0]);
//        }
//    }
//}
