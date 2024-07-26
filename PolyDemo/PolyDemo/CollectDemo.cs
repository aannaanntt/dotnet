//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//     class CollectDemo
//    {

//        static void Main(string[] args)
//        {
//            //int[] arr = new int[3];
//            //arr[0] = 1;
//            //arr[1] = 2;
//            //arr[2] = 3;

//            //Array.Resize(ref arr,4);
//            //arr[3] = 4;

//            //ArrayList al = new ArrayList(10);
//            //List<int> list = new List<int>();
//            //al.Add(1);
//            //al.Add("Anant");
//            //Console.WriteLine(al.Capacity);
//            //Console.WriteLine(list.Capacity);
//            //foreach(Object i in al)
//            //{
//            //    Console.Write(i);
//            //}
//            //al.Insert(2, 25);

//            //foreach (Object i in al)
//            //{
//            //    Console.Write(i);
//            //}

//            //Hashtable ht = new Hashtable()
//            //{
//            //    {1,"Amit" },
//            //    {2,"Anant" }
//            //};
//            //Console.WriteLine(ht.GetHashCode()); 
//            //Console.WriteLine(ht.Count);
//            //foreach (DictionaryEntry item in ht)
//            //{
//            //    Console.WriteLine(item.Key + ":" + item.Value);
//            //}

//           // List<int> list = new List<int>();
//           // list.Add(1);
//           // list.Add(2);
//           // list.Add(3);

//           // List<int> list2 = new List<int>(); 
//           // list2.Add(1);
//           // list2.Add(4);
//           // list2.Add(3);
//           // //Console.WriteLine(list.Find(a => a > 2));

//           //List<int> l= list.Except(list2).ToList();
//           // foreach (int i in l)
//           // {
//           //     Console.WriteLine(i);
//           // }

//            int[] ints1 = { 1,2,3 };
//            int[] ints2 = { 1,2,4 };
          
//            int[] Except = ints1.Except(ints2).ToArray();
//            Console.WriteLine("Except Result");
//            foreach (int num in Except)
//            {
//                Console.WriteLine("{0} ", num);
//            }
//        }
//    }
//}

