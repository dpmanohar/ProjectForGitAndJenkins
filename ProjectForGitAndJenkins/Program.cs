using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForGitAndJenkins
{
    internal class Program
    {
        public void display()
        {
            int a = 16;
            int b = 6;
            Console.WriteLine("addition is : "+a + b);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.display(); 
        }
    }
}
