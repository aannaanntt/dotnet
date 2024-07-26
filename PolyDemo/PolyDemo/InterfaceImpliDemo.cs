//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{

//    interface I1 {
//        void show();
//    }
//    interface I2 {
//        void show();
//    }


//    class MyClass : I1, I2 { 
    
//         void I1.show() {

//            Console.WriteLine("Method of I1");


//        }

//        void I2.show()
//        {
//            Console.WriteLine("Method of I2");
//        }
        
          
//    }
//     class InterfaceImpliDemo
//    {
//        static void Main(string[] args) { 
//            MyClass mc = new MyClass();
//            ((I1)mc).show();
//            I2 obj1= new MyClass();
//            obj1.show();
        
//        }
//    }
//}
