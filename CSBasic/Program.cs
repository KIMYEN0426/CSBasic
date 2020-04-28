using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "김" + "예" + "은";
            Console.Write("Hello C#");
            int add = 2;
            //주석
            /*
             * 
             * 여러줄 주석
             */
            Console.WriteLine("Hello World");
            Console.Write("Hello world");
            Console.Write("Hello world");

            Console.WriteLine(7 % 3);
            Console.WriteLine('A');
            Console.WriteLine("A");

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");

            Console.WriteLine("안녕"[100]);

            Console.WriteLine(true);
            Console.WriteLine(true);

        }
    }
}
