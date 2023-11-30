using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato quadrato = new Quadrato();
            quadrato.L = float.Parse(Console.ReadLine());
            Console.Write(quadrato.L * quadrato.L);
            Console.ReadLine();
        }
    }
}
