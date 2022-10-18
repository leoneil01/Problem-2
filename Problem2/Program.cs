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

            Program2 full_name = new Program2("Juan Dela Cruz");
        }
    }

    class Program2
    {
        public string name;
        public Program2 (string name1)
        {
            name = name1;
        }
    }
}
