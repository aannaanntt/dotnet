
public class Student
{
    public int id { get; set; }
    public string Firstname { get; set; }
    public string LastName { get; set; }

    public string Gender { get; set; }

    public int AnnualSalary {  get; set; }

    public List<string> subjects { get; set; }

    public static List<Student> GetAllStudents()
    {
        List<Student> students = new List<Student> {
           new Student{id=1,Firstname="Anant",LastName="Mishra",Gender="Male",AnnualSalary=50000,subjects=getAllSubs("Anant")},
           new Student { id =2,Firstname="Salman",LastName="Uddin",Gender="Male",AnnualSalary= 100000,subjects=getAllSubs("Salman")},
           new Student{id=3,Firstname="Rahul",LastName="Tripathi",Gender="Male",AnnualSalary = 50000,subjects=getAllSubs("Rahul")},
           new Student{id=4, Firstname="Arti" , LastName="singh",Gender="Female",AnnualSalary=10000,subjects=getAllSubs("Arti")}
   };

        return students;
    }

    public static List<string> getAllSubs(string name)
    {
        List<string> subs = null;
        switch (name)
        {
            case "Anant": subs= new List<string> { "c#", "Java", "Spring boot" };
                break;
            case "Salman": subs = new List<string> { "MBA", "Marketing", "Sales" };
                break;
            case "Rahul": subs = new List<string> { "Java", "spring boot", "hibernate" };
                break;
            case "Arti": subs = new List<string> { "Hindi", "English", "Maths" };
                break;
            default:
                subs = new List<string>();
                break;
        }



        return subs;
    }

    public static void Main(string[] argd)
    {
        //var res = from student in GetAllStudents()
        //          where student.Gender=="Male"
        //          select student;
        //foreach (var item in res)
        //{
        //    Console.WriteLine(item);
        //}

        //int[] numbers = { 1, 2, 3, 4, 5, 3, 12, 34 };

        //IEnumerable<int> res = from num in numbers
        //          where num%2 == 0
        //          select num;

        //IEnumerable<Student> res = GetAllStudents().Where(st => st.Gender == "Male");
        //int[] numbers = { 1, 2, 3, 4, 5, 3, 12, 34 };
        //var res=numbers.Where(i=>i%2==0).Max();
        //var res2 = numbers.Where(i => i % 2 == 0).Sum();
        //var res3 = numbers.Where(i => i % 2 == 0).Count();
        //var res4 = numbers.Where(i=>i%2==0).Average();

        //string[] countries = { "India","USA","UK"};
        //var res6 = countries.Aggregate("Aus",(a,b)=> a+","+b);
        //var res7=numbers.Where(i => i % 2 == 0);
        //var res8 = numbers
        //    .Select((num, index) => new { Number = num, Index = index })
        //    .Where(num=>num.Number%2==0).Select(x=>x.Index);
        //var res9 = GetAllStudents().Select(s => s.id);
        //var res9 = GetAllStudents()
        //    .Where(s=>s.AnnualSalary>10000)
        //    .Select(s =>new {FullName=s.Firstname+" "+s.LastName, MonthlySalary=s.AnnualSalary/12});

        //IEnumerable<string>subs=from student in GetAllStudents()
        //                        from subject in student.subjects
        //                        select subject;

        //var subs = GetAllStudents()

        //         .SelectMany(s => s.subjects, (student, subject) => new { StudentName = student.Firstname, SubjectName = subject });

        //     foreach (var c in subs) { 
        //         Console.WriteLine(c);
        //     }
        // }

        //IOrderedEnumerable<Student> students = GetAllStudents()
        //    .OrderBy(s => s.AnnualSalary)
        //    .ThenBy(s => s.Firstname).ThenByDescending(s=>s.id);

        //IOrderedEnumerable<Student> students = from student in GetAllStudents()
        //                                       orderby student.AnnualSalary,student.Firstname,student.id descending
        //                                       select student;

        //foreach (var item in students)  
        //{
        //    Console.WriteLine(item.id+":"+item.AnnualSalary+ ":"+ item.Firstname);
        //}
        //
        string[] countries = {"India","Pakistan","Vietnam","USA","UK","Germany" };
      IEnumerable<string> ienum= (from country in countries
                                 select country).Skip(3);
        foreach (string country in ienum) {
            Console.WriteLine(country);


        }
    }
    public override string ToString()
    {
        return this.id+" "+this.Firstname+" "+this.LastName +" "+this.Gender;
    }

}
