using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PolyDemo
{
    [Serializable]
    class Employee
    {
       

        public Employee()
        {
            
        }
      
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }

      
    }
    class SerializationDemo
    {
        static void Main(string[] args)
        {
     
            Employee emp = new Employee() { id=2, name="Anant"};


               string jsonString= JsonSerializer.Serialize(emp);
     
                File.WriteAllText(@"D:\employee.json",jsonString);

            string jsonFromFile = File.ReadAllText(@"D:\employee.json");
         Employee desrialized=   JsonSerializer.Deserialize<Employee>(jsonFromFile);
                Console.WriteLine(desrialized);
            }
            }
        }
    