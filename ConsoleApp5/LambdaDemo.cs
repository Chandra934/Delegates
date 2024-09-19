using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public delegate string Greetings(string c);
    class LambdaDemo
    {
        static void Main(string[] args)
        {
            Greetings g =(name)=>
            {
                return "hello " + name + "vgm";
            };
           string str= g.Invoke("chandra");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
