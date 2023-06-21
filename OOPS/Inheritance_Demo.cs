using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //Inheritance allow us to define a new class based on the exisisting class.
    public class Inheritance_Demo //base class.
    {
        public string student = "Satya";

        public void Parent()
        {
            Console.WriteLine("This is my base class");
        }
        
    }
    public class Child:Inheritance_Demo //Derived class
    {
        public string student_Name = "Satya";
        public Child()
        {
            Console.WriteLine("This is my Derived class");
        }
        public void Name()
        {
            Console.WriteLine("Satya");
        }

    }
}
