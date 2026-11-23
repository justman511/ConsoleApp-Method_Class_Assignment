using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Method_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MethodClassAssignment class
            MethodClassAssignment methodClass = new MethodClassAssignment();
            
            // Call the PrintSum method
            methodClass.PrintSum(5, 10);

            // Call the PrintSum method, specifying the parameters explicitly
            methodClass.PrintSum(a: 15, b: 20);
        }
    }
}
