//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace PolyDemo
//{
//     class FileHandling
//    {
//        static void Main(string[] args)
//        {
//            string path = @"D:\demo.txt";

//          if(File.Exists(path)) {
//                Console.WriteLine("Found");

//                string str=File.ReadAllText(path);
//                Console.WriteLine(str);
//                File.Copy(@"D:\demo.txt",@"D:\demo1.txt");
//            }
//            else
//            {
//                Console.WriteLine("File not found");
//            }
//        }
//    }
//}
