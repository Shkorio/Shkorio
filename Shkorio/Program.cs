using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shkorio
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Random r = new Random();
            int a = r.Next(0, 101);
            while (true)
            {
                string t = Console.ReadLine();
                int b = Convert.ToInt32(t);
                if (a > b)
                {
                    Console.WriteLine("Больше");
                }
                if (a < b)
                {
                    Console.WriteLine("Меньше");
                }
                if (a == b)
                {
                    Console.WriteLine("Угадал!");
                    break;
                }
                
            }
            Console.ReadKey();



        }
    }
}
