
// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.CompilerServices;
// using System.Runtime.Intrinsics.X86;


// namespace dotnet{
// public class Student
// {
//     public int id { get; set; }
//     public string Firstname { get; set; }
//     public string LastName { get; set; }

//     public string Gender { get; set; }

//     public int AnnualSalary {  get; set; }

//     public string Class { get; set; }

//     public List<string> subjects { get; set; }

//     public static List<Student> GetAllStudents()
//     {
//         List<Student> students = new List<Student> {
//            new Student{id=1,Firstname="Anant",LastName="Mishra",Gender="Male",AnnualSalary=50000,subjects=getAllSubs("Anant"),Class="Tenth"},
//            new Student { id =2,Firstname="Salman",LastName="Uddin",Gender="Male",AnnualSalary= 100000,subjects=getAllSubs("Salman"),Class="sixth"},
//            new Student{id=3,Firstname="Rahul",LastName="Tripathi",Gender="Male",AnnualSalary = 50000,subjects=getAllSubs("Rahul"),Class="fourth"},
//            new Student{id=4, Firstname="Arti" , LastName="singh",Gender="Female",AnnualSalary=10000,subjects=getAllSubs("Arti"),Class="sixth"},
//              new Student{id=4, Firstname="Arti" , LastName="singh",Gender="Female",AnnualSalary=10000,subjects=getAllSubs("Arti"),Class="seventh"}
//    };

//         return students;
//     }

//     public static List<string> getAllSubs(string name)
//     {
//         List<string> subs = null;
//         switch (name)
//         {
//             case "Anant": subs= new List<string> { "c#", "Java", "Spring boot" };
//                 break;
//             case "Salman": subs = new List<string> { "MBA", "Marketing", "Sales" };
//                 break;
//             case "Rahul": subs = new List<string> { "Java", "spring boot", "hibernate" };
//                 break;
//             case "Arti": subs = new List<string> { "Hindi", "English", "Maths" };
//                 break;
//             default:
//                 subs = new List<string>();
//                 break;
//         }



//         return subs;
//     }

//     public static void Main(string[] argd)
//     {
//         //var res = from student in GetAllStudents()
//         //          where student.Gender=="Male"
//         //          select student;
//         //foreach (var item in res)
//         //{
//         //    Console.WriteLine(item);
//         //}

//         //int[] numbers = { 1, 2, 3, 4, 5, 3, 12, 34 };

//         //IEnumerable<int> res = from num in numbers
//         //          where num%2 == 0
//         //          select num;

//         //IEnumerable<Student> res = GetAllStudents().Where(st => st.Gender == "Male");
//         //int[] numbers = { 1, 2, 3, 4, 5, 3, 12, 34 };
//         //var res=numbers.Where(i=>i%2==0).Max();
//         //var res2 = numbers.Where(i => i % 2 == 0).Sum();
//         //var res3 = numbers.Where(i => i % 2 == 0).Count();
//         //var res4 = numbers.Where(i=>i%2==0).Average();

//         //string[] countries = { "India","USA","UK"};
//         //var res6 = countries.Aggregate("Aus",(a,b)=> a+","+b);
//         //var res7=numbers.Where(i => i % 2 == 0);
//         //var res8 = numbers
//         //    .Select((num, index) => new { Number = num, Index = index })
//         //    .Where(num=>num.Number%2==0).Select(x=>x.Index);
//         //var res9 = GetAllStudents().Select(s => s.id);
//         //var res9 = GetAllStudents()
//         //    .Where(s=>s.AnnualSalary>10000)
//         //    .Select(s =>new {FullName=s.Firstname+" "+s.LastName, MonthlySalary=s.AnnualSalary/12});

//         //IEnumerable<string>subs=from student in GetAllStudents()
//         //                        from subject in student.subjects
//         //                        select subject;

//         //var subs = GetAllStudents()

//         //         .SelectMany(s => s.subjects, (student, subject) => new { StudentName = student.Firstname, SubjectName = subject });

//         //     foreach (var c in subs) { 
//         //         Console.WriteLine(c);
//         //     }
//         // }

//         //IOrderedEnumerable<Student> students = GetAllStudents()
//         //    .OrderBy(s => s.AnnualSalary)
//         //    .ThenBy(s => s.Firstname).ThenByDescending(s=>s.id);

//         //IOrderedEnumerable<Student> students = from student in GetAllStudents()
//         //                                       orderby student.AnnualSalary,student.Firstname,student.id descending
//         //                                       select student;

//         //foreach (var item in students)  
//         //{
//         //    Console.WriteLine(item.id+":"+item.AnnualSalary+ ":"+ item.Firstname);
//         //}
//         //
//        // string[] countries = {"India","Pakistan","Vietnam","USA","UK","Germany" };
//     //   IEnumerable<string> ienum= (from country in countries
//     //                              select country).Skip(3);
//         // IEnumerable<string> ienum=countries.TakeWhile(x=>x.Length>3);


//         // foreach (string country in ienum) {
//         //     Console.WriteLine(country);


//         // }

//     //     IEnumerable<Student> students= GetAllStudents();
//     //     System.Console.WriteLine("Print Page number 1,2,3 or 4");
//     //     int pageNumber=0;
//     //    if(int.TryParse(Console.ReadLine(),out pageNumber)){
//     //         if(pageNumber>=1 && pageNumber<=4){
//     //             int pageSize=3;

//     //             IEnumerable<Student> result=students.Skip((pageNumber-1) * pageSize).Take(pageSize);
//     //             Console.WriteLine();
//     //             Console.WriteLine("Display page"+ pageNumber);
//     //             foreach(var item in result){
//     //                 System.Console.WriteLine(item.id+" "+ item.Firstname);
//     //             }
//     //             System.Console.WriteLine();
                
//     //         }else{
//     //      System.Console.WriteLine("Page number must be between 1 to 4");

//     //         }
//     //    }else{
//     //      System.Console.WriteLine("Page number must be between 1 to 4");
//     //    }

//         // int res= (from stud in GetAllStudents()
//         //                         where stud.Gender=="Male"
//         //                         select stud).Count();
//         //          GetAllStudents()
                
//         //         .Add(new Student{id=6,Firstname="xyz",LastName="abc",Gender="Male",AnnualSalary=12000,subjects= new List<string>{"Science","Maths"}});
         
//         //         System.Console.WriteLine(res);

//         //  var optdct= GetAllStudents().ToLookup(x=>x.Firstname);
//         //        System.Console.WriteLine("Employees group by firstName");
//         //        foreach(var kvp in optdct){
//         //         System.Console.WriteLine(kvp.Key);

//         //         foreach(var stu in optdct[kvp.Key]){
//         //                 System.Console.WriteLine(stu.LastName+ " "+stu.Gender);
//         //         }
//         //        }

//         //        ArrayList list = new ArrayList();
//         //        list.Add(1);
//         //        list.Add(2);
//         //        list.Add(3);
//         //        list.Add("SA");
//         //     //  IEnumerable<int> ienum=  list.Cast<int>();

//         //         IEnumerable<int> ienum=  list.OfType<int>();

//         //      foreach(var i in ienum){
//         //         System.Console.WriteLine(i);
//         //      }

//     // var ienum=  GetAllStudents().AsEnumerable()
//     // .Where(x=> x.Gender=="Male").OrderByDescending(x=>x.AnnualSalary).Take(2);
//     //     foreach(var item in ienum){
//     //         System.Console.WriteLine(item.ToString());
//     //     }

//     //   IEnumerable<IGrouping<string,Student>> ienum=  from stu in GetAllStudents()
//     //                                                 group stu by stu.Class into estu
//     //                                                 orderby estu.Key
//     //                                                 select new {

//     //                                                     Key=estu.Key,
//     //                                                     Students=estu.Order(x=>x.Firstname)
//     //                                                 };
    
//     // foreach(var item in ienum){
//     //         System.Console.WriteLine("{0} {1}", item.Key,item.Students.Count());
//     //         System.Console.WriteLine("--------------------");
//     //         foreach(var emp in item.Students ){
//     //             System.Console.WriteLine(emp.Firstname+":"+emp.LastName);
//     //         }
//     // }

// int[] arr = {1,2,3,42,12,32,3412,3,432,31};
//         int res = arr.ElementAt(1);
//         System.Console.WriteLine(res);
//     }
//     public override string ToString()
//     {
//         return this.id+" "+this.Firstname+" "+this.LastName +" "+this.Gender+" "+this.Class;
//     }

// }
// }