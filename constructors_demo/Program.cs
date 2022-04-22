using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_demo
{
    class Program
    {
        //default Constructor
        public Program()
        {
            Console.WriteLine("This is invoke of default Constructor ");
        }
        //parametrize Constructor
        public Program(string Name)
        {
            Console.WriteLine("output from parametrize Constructor  hello " +  Name );
        }
        //method over loading..
        void Add_number(int a , int b )
        {
            Console.WriteLine("Addition of two Number is " + a + b);
        } 
        void Add_number (int a , int b,int c)
        {
            Console.WriteLine("Addition of three number is " + a + b + c);
        }



        static void Main(string[] args)
        {
            Program pr_obj1 = new Program();
            Program pr_obj2 = new Program("Saurabh");
            Program p = new Program();
            p.Add_number(3, 5, 7);
            p.Add_number(98,15);
        }
    }
}
