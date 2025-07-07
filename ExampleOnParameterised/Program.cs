using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOnParameterised
{
    /*
     * 
     */
    //class Student
    //{
    //    int sid;
    //    string sname;
    //    int sage;
    //    public Student(int sid, string sname, int sage)
    //    {
    //        this.sid = sid;
    //        this.sname = sname;
    //        this.sage = sage;
    //    }
    //}
    /*
     * This is an example of a parameterized constructor in C#.
     * THis is a keyword that is used to create a constructor that takes parameters.
     * This is used for current class instance variables.
     * 
     */
    class myclass
    {
        int a;
        int b;

        public myclass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void display()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass(10,20);
            obj.display();
        }
    }
}
