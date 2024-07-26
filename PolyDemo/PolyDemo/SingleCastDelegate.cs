//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//    public delegate void Calculation(int a,int b);
//     class SingleCastDelegate
//    {
        
//        public static void Addition(int a, int b)
//        {
//            int res= a + b;
//            Console.WriteLine(res);
//        }


//        static void Main(string[] args) {
//            Calculation c = new Calculation(Addition);
//            c.Invoke(2, 3);
        
//        }

//    }
//}
