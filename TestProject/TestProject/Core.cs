using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Core
    {
        String str = "";
        int[] a = new int[100];
        int num = 0;
        int i = 0;
        public int Mistake = 0;
        public void GeneralTr(string str, int snFirst)
        {


            try
            {
                    char[] part = str.ToArray();
                    int x = 0;
                    for (int i = part.Length - 1, k=0; i >= 0; i--, k++)
                    {
                    if (i > 9)
                    {
                        Console.WriteLine("Cлишком большое число!");
                        Mistake = 1;
                        return;
                    }

                    int step = 1;
                        if (part[i].Equals('A') || part[i].Equals('a'))
                        {
                            x = 10;
                        } else
                        if (part[i].Equals('B') || part[i].Equals('b'))
                        {
                            x = 11;
                        } else
                        if (part[i].Equals('C') || part[i].Equals('c'))
                        {
                            x = 12;
                        } else
                        if (part[i].Equals('D') || part[i].Equals('d'))
                        {
                            x = 13;
                        } else
                        if (part[i].Equals('E') || part[i].Equals('e'))
                        {
                            x = 14;
                        } else
                        if (part[i].Equals('F') || part[i].Equals('f'))
                        {
                            x=15;
                        } else
                        {
                            x = (int)Char.GetNumericValue(part[i]);
                        }

                        if (x== -1)
                        {
                            Console.WriteLine("Введен неверный формат!");
                            Mistake = 1;
                            return;
                        }

                            if (x>snFirst-1)
                    {
                        Console.WriteLine("Невозможно! Числа не присутствуют в данной системе счисления");
                        Mistake = 1;
                        return;
                    }

                        for (int l = 0; l < k; l++)
                        {
                            step *= snFirst;
                        }
                        num += step * x;
                    }
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
           

        }
        

        public void TrInSn(int snEnd)
        {
            if (Mistake != 1){
                for (i = 0; num >= 1; i++)
                {
                    a[i] = num % snEnd;
                    num = num / snEnd;
 
                }

                for (i--; i >= 0; i--)
                {


                    if (a[i] < 10)
                    {
                        str = str + a[i].ToString();
                    }
                    if (a[i] == 10)
                    {
                        str = str + "A";
                    }
                    if (a[i] == 11)
                    {
                        str = str + "B";
                    }
                    if (a[i] == 12)
                    {
                        str = str + "C";

                    }
                    if (a[i] == 13)
                    {
                        str = str + "D";

                    }
                    if (a[i] == 14)
                    {
                        str = str + "E";

                    }
                    if (a[i] == 15)
                    {
                        str = str + "F";

                    }
                }
                }
           

            Console.WriteLine(str);
        }
    }
}
