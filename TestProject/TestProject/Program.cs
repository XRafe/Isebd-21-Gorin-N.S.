using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Core core = new Core();
            int x2 = 0;
            int x3 = 0;
            string str = "";
            try
            {
                Console.WriteLine("Введите число, затем с/с:");
                str = Console.ReadLine();
                x2 = int.Parse(Console.ReadLine());

                if (2 > x2 || x2 > 16)
                {
                    Console.WriteLine("Данная система счисления - не реализована");
                    Console.ReadLine();
                    return;
                }
                core.GeneralTr(str, x2);
                if (core.Mistake != 1) {
                    Console.WriteLine("Введите систему счисления в которую требуется перевести:");
                    x3 = int.Parse(Console.ReadLine());
                    if (2 > x3 || x3 > 16)
                    {
                        Console.WriteLine("Данная система счисления - не реализована");
                        Console.ReadLine();
                        return;
                    }
                }
               
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
                return;
            }
         

            core.TrInSn(x3);
            Console.ReadLine();
        }
    }
}
