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
            var age = 32.5;
            Person joachim = new Person();
            var andreas = new Person();
            Console.WriteLine("Alderen min er "+age+ " år");
            Console.WriteLine($"Alderen min er {age} år");
            Console.ReadLine();
        }
    }
}
