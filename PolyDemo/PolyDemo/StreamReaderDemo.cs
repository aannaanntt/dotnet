//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//    class StreamReaderDemo
//    {
//        static void Main(string[] args)
//        {
//            string path = @"D:\myFile.txt";
//            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
//            {

//                using (StreamReader sr = new StreamReader(file))
//                {
//                    string line;
//                    while((line=sr.ReadToEnd()) != "")
//                    {
                       
//                        Console.WriteLine(line);
//                    }
                   

//                }
//                int num1 = 10;
//                object obj = num1;
//                int num2 = (int)obj;
//                Guid g = Guid.NewGuid();
//                Console.WriteLine(g.ToString());
//                object a = "Adil";
//              bool ans=  a is string;
//                if (a is string) {
//                    Console.WriteLine("Yes it's string");
//                }
//                else
//                {
//                    Console.WriteLine("No it's not"); 
//                }

//                object ab = 123;
//                string s = ab as string;
               
//                Console.WriteLine(s);

//                string name = null;
//                string res = name ?? "Annonymous";
//                //if( name != null)
//                //{
//                //    res= name; 
//                //}


//                Console.WriteLine(res);
//            }
//        }
//    }
//}
