using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.Parent();
            child.Name();
           Console.WriteLine( child.student_Name);
            Console.WriteLine(child.student);

            Console.ReadLine();
        }
    }
}
