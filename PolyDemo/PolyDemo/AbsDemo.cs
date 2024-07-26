//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PolyDemo
//{
//    class Employee
//    {
//        public int EmpId;
//        public string Name;
//        public double GrossPay;

//        public double TaxDed = 0.1;

//        public double NetSalary;

//        public Employee(int eId,string name,double grosSal)
//        {
//            this.EmpId = eId;
//            this.Name = name;
//            this.GrossPay = grosSal;
            
//        }

//        private void CalculateSal()
//        {
//            if(GrossPay >= 30000)
//            {
//                NetSalary = GrossPay - (TaxDed * GrossPay);
//                Console.WriteLine("Your salary is {0}",NetSalary);
//            }
//            else
//            {
//                Console.WriteLine("Your salary is {0}",GrossPay);
//            }
//        }

//        public void ShowEmployeeDetails()
//        {
//            Console.WriteLine("Employee name is {0}",Name);
//            this.CalculateSal();
//        }
//    }
//     class AbsDemo
//    {
//        static void Main(string[] args)
//        {
//            var demo = new Employee(1,"Anant",20000);
//            demo.ShowEmployeeDetails();
//        }
//    }
//}
