//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//    class Parent
//    {
//        public void Show()
//        {
//            Console.WriteLine("Parent class method");
//        }
//    }
//    class Child : Parent
    
//   {
//        public new void Show()
//        {
//            base.Show();
//            Console.WriteLine("child class method");
//        }

//    }
//    class Employee
//    {
//        public string fname;
//        public string lname;
//        public void PrintFullName()
//        {
//            Console.WriteLine(fname+":"+lname);
//        }
//    }
//    class PartTimeEmployee : Employee {

//        public new void  PrintFullName()
//        {
//            Console.WriteLine(fname + ":" + lname+" "+"PTE");
//        }
//    }
//    class FullTimeEmployee : Employee {
//        public new void PrintFullName()
//        {
//            Console.WriteLine(fname + ":" + lname+" "+"FTE");
//        }

//    }


//     class MethodHideDemo
//    {
//        static void Main(string[] args)
//        {
//            //Parent c = new Child();

//            PartTimeEmployee pte = new PartTimeEmployee();
//            pte.fname = "Anant";
//            pte.lname = "Mishra";
//            pte.PrintFullName();
//        }
//    }
//}
