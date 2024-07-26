
//using System;
//using System.Runtime.CompilerServices;

//namespace _NET
//{ 

//    class Exampple
//    {
//        string name;
//        int age;
//        public Exampple(string name,int age)
//        {
//            this.name = name;
//            this.age = age;
            
//        }

//        public Exampple(Exampple e)
//        {
//            this.name=e.name;
//            this.age = e.age;
//        }

//        public void getData()
//        {
//            Console.WriteLine("Name is {0}",name);
//            Console.WriteLine("Age is {0}",age);
//        }

//    }

//    class CopyConstructor
//    {
   
//        public static void Main(string[] args) {


//            Exampple obj = new Exampple("Anat", 34);
//            Exampple obj2 = new Exampple(obj);

//            obj.getData();
//            obj2.getData();
//        }
//    }
//}