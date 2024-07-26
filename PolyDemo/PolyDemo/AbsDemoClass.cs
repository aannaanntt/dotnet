//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//    abstract class Person 
//    {
//        public string Firstname;
//        public string Lastname;
//        public int age;
//        public long moibile;

//         public abstract int PersonId { get; set; }

//        public abstract void PrintDetails();
//    }
//     class Student : Person{
//        public int rollNo;
//        public int fees;

//        public override int PersonId
//        {
//            set
//            {
//                this.rollNo = value;
//            } 
//            get
//            {
//                return this.rollNo;
//            }

         
//        }
//        public override void PrintDetails()
//        {
//            string stuname = this.Firstname +" "+ this.Lastname;
//            Console.WriteLine(stuname);
//            Console.WriteLine(this.age);
//            Console.WriteLine(this.moibile);
//            Console.WriteLine(this.rollNo);
//            Console.WriteLine(this.fees);
//        }
//    }
//    //class Teacher : Person{
//    //    public string qualification;
//    //    public int salary;

//    //    public override void PrintDetails()
//    //    {
//    //        string stuname = this.Firstname + " " + this.Lastname;
//    //        Console.WriteLine(stuname);
//    //        Console.WriteLine(this.age);
//    //        Console.WriteLine(this.moibile);
//    //        Console.WriteLine(this.qualification);
//    //        Console.WriteLine(this.salary);
//    //    }
//    //}
//     class AbsDemoClass
//    {
//        static void Main(string[] args) {
//        Student student = new Student();
//            student.Firstname = "Anant";
//            student.Lastname = "Mishra";
//            student.age = 23;
//            student.moibile = 122311211111111;
//            student.PersonId = 23;
//            Console.WriteLine(student.PersonId);
//            student.fees = 4000;
//            student.PrintDetails();
//            //Teacher teacher = new Teacher();
//            //teacher.Firstname = "Rahul";
//            //teacher.PrintDetails();
//        }
//    }
//}
