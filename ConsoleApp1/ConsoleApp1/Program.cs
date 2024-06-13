using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            string[] a = { "vijju","Likitha","alli"};
            for(int i = 0; i < a.Length; i++) 
            { 
                    string s = a[i];
                   if (s.Contains("i"))
                {
                    Console.WriteLine(s);
                }
                   else
                {
                    Console.WriteLine("nothing");
                }
                   Console.ReadKey();
            }
        }
    }
}
