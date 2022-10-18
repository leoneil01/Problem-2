using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        string name;
        int age;

        Program()
        {
            Console.WriteLine("Constructor is called: ");
        }

        static void Main(string[] args)
        {
            Program construc = new Program();
            Console.WriteLine(construc.name);
            Console.WriteLine(construc.age);
        }
    }
}
