
//using System;
//using System.Runtime.CompilerServices;

//namespace _NET
//{ 

//  class Person
//    {
//        public string Name;
//        public int Age;

//        public Person(string name,int age)

//        {
//            this.Name = name;   
//            this.Age = age;

//            Console.WriteLine("Constructor called");

//        }

//        public string getName()
//        {

//        return this.Name; 
//        }

//        public int getAge() { return this.Age; }
//        ~Person()
//        {
//            Console.WriteLine("Destructor called");
//        }
//    }
//class  DestructorDemo
//    {


   
//        public static void Main(string[] args) {
//            Person p = new Person("Anant", 28);
//            Console.WriteLine(p.getAge() +" " +p.getName());
//        }
//    }
//}