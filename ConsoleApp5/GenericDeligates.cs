using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
     class GenericDeligates
    {
        public delegate double Delegate1(int x, float y, double z);
        public delegate void Delegate2(int x, float y, double z);
        public delegate bool Delegate3(string d);
       // public static double Add(int x, float y, double z)
        //{
          //  return x + y + z;
        //}
       // public static void AddNums1(int x, float y, double z)
        //{
          //  Console.WriteLine(x + y + z);
       // }
        public static bool Check(string s)
        {
            if (s.Length > 5)
                return true;
            else return false;
                    
        }
        static void Main()
        {
            //Delegate1 d = Add;
            Func<int, float, double, double> d = (x,y,z)=>
            {
                return x + y + z;
            };
            double result = d.Invoke(10, 3.5f, 6.89);
            Console.WriteLine(result);
            // Delegate2 d2 = AddNums1;
            Action<int, float, double> d2 = (x,y,z)=>
            {
                Console.WriteLine(x + y + z);
            };
            d2.Invoke(10, 3.5f, 6.89);
            //Delegate3 d3 = Check;
            Predicate<string> d3 = Check;
            bool b=d3.Invoke("chandra");
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
