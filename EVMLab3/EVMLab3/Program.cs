using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVMLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Core core = new Core();
            int x2 = 0;
            string Firstnum = "";
            string Secondnum = "";
            string Sign = "";
            try
            {
                Console.WriteLine("Введите первое число, арифметическую операцию, затем второе число и с/с:");
                Firstnum = Console.ReadLine();
                Sign = Console.ReadLine();
                Secondnum = Console.ReadLine();
                x2 = int.Parse(Console.ReadLine());

                if (2 > x2 || x2 > 16)
                {
                    Console.WriteLine("Данная система счисления - не реализована");
                    Console.ReadLine();
                    return;
                }
                core.GeneralTr(Firstnum, Secondnum, x2);
                core.TrInSn(Sign);
               
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.ReadLine();
                return;
            }
         
            
            Console.ReadLine();
        }
    }
}
