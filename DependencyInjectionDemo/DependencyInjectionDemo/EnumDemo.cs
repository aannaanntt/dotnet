using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    enum Days
    {
        Mon,
        Tue,
        wed
    }
    internal class EnumDemo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Days[] df = (Days[])Enum.GetValues(typeof(Days));
            foreach (Days d in df)
            {

                Console.WriteLine(d);
            }

        }
    }
}
