using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet{
    public class Department{
        public int id {get; set;}
        public string name {get; set;}

        public static List<Department> GetAllDept(){
           return new List<Department>(){
            new Department{id=1,name="HR"},
            new Department{id=2,name="IT"},
            new Department{id=3,name="Payroll"}

           };
           
      
    }

    }

    public class Employee{


        public int id { get; set; }
        public string  Name { get; set; }

        public int  DepartmentId { get; set; }

        public static List<Employee> getAllEmnployee(){
            return new List<Employee>(){
            new Employee{id=1,Name="Mark",DepartmentId=1},
            new Employee{id=2,Name="Steve",DepartmentId=2},
            new Employee{id=3,Name="Ben",DepartmentId=2},
            new Employee{id=4,Name="Philip",DepartmentId=1},
            new Employee{id=5,Name="Mary",DepartmentId=2},
            new Employee{id=6,Name="Valarie",DepartmentId=2},
            new Employee{id=7,Name="John",DepartmentId=1},
            new Employee{id=8,Name="Pam",DepartmentId=2},
            new Employee{id=9,Name="Stacey",DepartmentId=2},
            new Employee{id=10,Name="Andy"},
              new Employee{id=10,Name="Andy"},



            };
        }
        
    }

    public class Program{

        static void Main(string[] args){
        //    var ewmplByDept = Department.GetAllDept()
        //                             .GroupJoin(Employee.getAllEmnployee(),
        //                             d =>d.id,
        //                             e=>e.DepartmentId,
        //                             (department,employees)=> new {
        //                                 Department=department,
        //                                 Employee=employees

        //                             }); 

    //  var ewmplByDept=   from d in Department.GetAllDept()
    //     join e in Employee.getAllEmnployee()
    //     on d.id equals e.id into eGroup
    //     select new {
    //         Department=d,
    //         Employee=eGroup
    //     };

    //     foreach(var dept in ewmplByDept){
    //         System.Console.WriteLine(dept.Department.name);
    //         foreach(var emp in dept.Employee){
    //             System.Console.WriteLine(" "+ emp.Name);
    //         }
    //     }
    //     }

        // var res= Employee.getAllEmnployee().Join(Department.GetAllDept(),
        //                             e=>e.DepartmentId,
        //                             d=>d.id,
        //                             (employee,department)=> new {
                                    
        //                                     EmployeeName=employee.Name,
        //                                     DepartmentName=department.name
        //                             });

        //     foreach(var emp in res){
        //         System.Console.WriteLine(emp.EmployeeName+"\t"+emp.DepartmentName);

        //     }          

        // var res= from e in Employee.getAllEmnployee()
        //         join d in Department.GetAllDept()
        //         on e.DepartmentId equals d.id
        //         into eGroup from d in eGroup.DefaultIfEmpty()
        //         select new {
        //                 employeeName=e.Name,
        //                 deptName= d
        //                 == null?"No department":d.name
        //         };

// var res= Employee.getAllEmnployee().GroupJoin(Department.GetAllDept(),
//                             e=>e.DepartmentId,
//                             d=>d.id,
//                             (emp,dept)=>new {
//                                 emp,dept
//                             }).SelectMany(z=>z.dept.DefaultIfEmpty(),(a,b)=>new{
//                                 EmployeeName=a.emp.Name,
//                                 DepartmentName= b==null?"No department":b.name
//                             });
//         foreach(var item in res){
//            System.Console.WriteLine(item.employeeName+"\t"+item.deptName); 
//         }

        // var res= from d in Department.GetAllDept()
        //          from e in Employee.getAllEmnployee()
                
        //         select new {e,d};

        //var res= Employee.getAllEmnployee().SelectMany(e=>Department.GetAllDept(),(e,d)=> new {e,d});
        // var res= Employee.getAllEmnployee().Join(e=>Department.GetAllDept(),e=>true,d=>true,(e,d)=> new {e,d});

        // foreach(var v in res){
    //     //     System.Console.WriteLine(v.e.Name+"\t"+v.d.name);
    //     // }

    //    var res= Employee.getAllEmnployee().Select(c=> new {c.id,c.Name}).Distinct();
    //         foreach(var item in res){
    //             System.Console.WriteLine(item);
    //         }
    }
}
}