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
            Console.WriteLine(full_name.name);

            Program3 value = new Program3(10, 10);
            Console.WriteLine($"{value.val1} {value.val2}");
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

    class Program3
    {
        public int val1;
        public int val2;
        public Program3(int num1, int num2)
        {
            val1 = num1;
            val2 = num2;
        }
    }
}
