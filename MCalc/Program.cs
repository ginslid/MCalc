using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            run();
        }

        private static void run()
        {
            // cria uma nova instância da classe menu e a chama
            Info start = new Info();
            start.menu();
            Console.ReadLine();
        }

    }
}
