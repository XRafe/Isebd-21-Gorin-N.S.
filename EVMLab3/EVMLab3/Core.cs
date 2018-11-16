using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVMLab3
{
    public class Core
    {
        String str = "";
        String str2 = "";
        int[] a = new int[100];
        int[] b = new int[100];
        int num = 0;
        int num2 = 0;
        int i = 0;
        int j = 0;
        public int Mistake = 0;
        public void GeneralTr(string Firstnum, string Secondnum, int snFirst)
        {


            try
            {
                    char[] part = Firstnum.ToArray();
                    char[] part2 = Secondnum.ToArray();
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

                for (int j = part2.Length - 1, k = 0; j >= 0; j--, k++)
                {
                    if (j > 9)
                    {
                        Console.WriteLine("Cлишком большое число!");
                        Mistake = 1;
                        return;
                    }


                    int step = 1;
                    if (part2[j].Equals('A') || part2[j].Equals('a'))
                    {
                        x = 10;
                    }
                    else
                    if (part2[j].Equals('B') || part2[j].Equals('b'))
                    {
                        x = 11;
                    }
                    else
                    if (part2[j].Equals('C') || part2[j].Equals('c'))
                    {
                        x = 12;
                    }
                    else
                    if (part2[j].Equals('D') || part2[j].Equals('d'))
                    {
                        x = 13;
                    }
                    else
                    if (part2[j].Equals('E') || part2[j].Equals('e'))
                    {
                        x = 14;
                    }
                    else
                    if (part2[j].Equals('F') || part2[j].Equals('f'))
                    {
                        x = 15;
                    }
                    else
                    {
                        x = (int)Char.GetNumericValue(part2[j]);
                    }

                    if (x == -1)
                    {
                        Console.WriteLine("Введен неверный формат!");
                        Mistake = 1;
                        return;
                    }

                    if (x > snFirst - 1)
                    {
                        Console.WriteLine("Невозможно! Числа не присутствуют в данной системе счисления");
                        Mistake = 1;
                        return;
                    }

                    for (int l = 0; l < k; l++)
                    {
                        step *= snFirst;
                    }
                    num2 += step * x;
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            
           

        }
        

        public void TrInSn(string Sign)
        {


            string str3 = "";
            if (Mistake != 1){
                for (i = 0; num >= 1; i++)
                {
                    a[i] = num % 2;
                    num = num / 2;
 
                }

                for (j = 0; num2 >= 1; j++)
                {
                    b[j] = num2 % 2;
                    num2 = num2 / 2;

                }


                for (i--; i >= 0; i--)
                {

                    str = str + a[i].ToString();
                    
                }


                for (j--; j >= 0; j--)
                {

                    str2 = str2 + b[j].ToString();
                    
                }

                char[] number1 = str.ToArray();
                char[] number2 = str2.ToArray();
                int[] end = new int[100];
                int max = 0;
                int MAX = 0;
                if (number1.Length - 1 > number2.Length - 1)
                {
                    max = number1.Length - 1;
                    MAX = number1.Length;
                } else
                {
                    max = number2.Length - 1;
                    MAX = number2.Length;
                }

                if (Sign == "+")
                {
                    for (int f = number1.Length - 1, s = number2.Length - 1; f>=0 & s>=0; max --, f--, s--)
                    {

                        if ((number1[f] == '0' & number2[s] == '1') || (number1[f] == '1' & number2[s] == '0'))
                        {
                            end[max] = 1;
                        }

                        if (number1[f] == '0' & number2[s] == '0')
                        {
                            end[max] = 0;
                        }

                        if (number1[f] == '1' & number2[s] == '1')
                        {
                            for (int t1=MAX; t1>max; t1--)
                            {
                                end[t1 + 1] = end[t1];
                            }

                            end[max] = 0;
                            max++;
                            end[max] = 0;
                            for (int ch = max; ch>0 ;ch--)
                            {
                                if (end[ch-1]==0)
                                {
                                    end[ch - 1] = 1;
                                    end[ch] = 0;
                                } 

                            }
                        }

                        if (f<=0)
                        {
                            for (s--, max--; s >= 0; s--, max--)
                            {
                                if (number2[s] == '0')
                                {
                                    end[max] = 0;
                                }
                                if (number2[s] == '1')
                                {
                                    end[max] = 1;
                                }
                            }
                        }
                        if (s<=0)
                        {
                            for (f--, max--; f >= 0; f--, max--)
                            {
                                if (number1[f] == '0')
                                {
                                    end[max] = 0;
                                } else if (number2[f] == '1')
                                {
                                    end[max] = 1;
                                }
                            }
                        }



                    }


                } else if (Sign == "-")
                {

                } else if (Sign == "*")
                {

                } else if (Sign == "/")
                {

                } else
                {
                    Console.WriteLine("Невозможно обработать арифметический знак");
                    return;
                }


                for (int e = 0; e<=MAX; e++)
                {

                    str3 = str3 + end[e].ToString();

                }



            }
           

            Console.WriteLine(str);

            Console.WriteLine(str2);
            
            Console.WriteLine(str3);


        }
    }
}
