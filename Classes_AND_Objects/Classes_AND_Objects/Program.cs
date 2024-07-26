
//using System;
//using System.Runtime.CompilerServices;

//namespace _NET
//{

//    class Person
//    {
//        public static  string PersonName;
//        public static int PersonAge;

//        public Person()
//        {
//            Console.WriteLine("default constructor");
//        }

//        static Person()
//        {
//            PersonName = "Annat";
//            PersonAge = 12;
//            Console.WriteLine("Static constructor invoked");
//        }

//        public void getDetails()
//        {
//            Console.WriteLine("Person details are {0} {1}",PersonName,PersonAge);
//        }
//    }

//    class Student
//    {
//     public   int rollNo;
//        public string fname;
//        public string lname;
//        public int standard;

//       public static string school="XYZ school";
//        public void printFullName()
//        {
//            Console.WriteLine("Fullname="+this.fname+this.lname);
//        }

//        public static void getInitials(ref Student st)
//        {
//            string fName=st.fname;
//            string lName = st.lname;
//            Console.WriteLine("Student initials"+ fName.ElementAt(0) + lName.ElementAt(0));
//        }

//    }
//    class Program
//    {
//        public Program()
//        {
//            Console.WriteLine("Cons called");
//        }

//        public Program(int a)
//        {
//            Console.WriteLine("Overrided cons {0}",a);
//        }

//        public static void Main(string[] args) { 
        
//            Student student = new Student();

//            student.rollNo = 1;
//            student.standard = 1;
//            student.fname="Ali";
//            student.lname = "Azgar";
            
//            student.printFullName();
//            Console.WriteLine(Student.school);
//            Student.getInitials(ref student);


//            Student student1 = new Student();
//            student1.rollNo = 2;

//            Person person = new Person();
//            person.getDetails();

//        }
//    }
//}