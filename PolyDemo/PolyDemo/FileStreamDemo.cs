//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace PolyDemo
//{
//     class FileStreamDemo
//    {

//       static void Main(string[] argd)
//        {
//            string path = @"D:\myFile.txt";
//            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Write))
//            {
//                string data = "Welcome to Learning";
//                byte[] write_data=Encoding.UTF8.GetBytes(data);
//                fs.Write(write_data,0,data.Length);
//                Console.WriteLine("Data added");
//            }
           
//        }
//    }
//}
