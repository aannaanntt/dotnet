//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//     class StreamWriterDemo
//    {
//        static void Main(string[] args)
//        {
//            string path = @"D:\myFile.txt";
           
//            using (FileStream file= new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
//            {
//                using (StreamWriter writer = new StreamWriter(file,Encoding.UTF8))
//                {
//                    int[] arr = { 11,22,33,44};
//                    //writer.WriteAsync("Anant");
//                    //writer.Write("Mishra");
//                    foreach (int i in arr)
//                    {

//                        writer.WriteLine(i);

//                    }
//                }
//                }


//                    Console.WriteLine("Creation done");
//            }
//        }
//    }

