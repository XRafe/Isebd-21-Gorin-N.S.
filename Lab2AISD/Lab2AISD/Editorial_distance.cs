using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2AISD
{
    class Editorial_distance
    {
        int[,] _array;
        public void distance()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            str1 = " " + str1;
            str2 = " " + str2;
            char[] st1 = str1.ToCharArray();
            char[] st2 = str2.ToCharArray();

            int cost = 0;
            _array = new int[str1.Length + 1, str2.Length + 1];
            for (int i = 0; i < str1.Length; i++)
            {
                _array[i, 0] = i;
            }
            for (int j = 0; j < str2.Length; j++)
            {
                _array[0, j] = j;
            }
            for (int i = 1; i < str1.Length; i++)
            {
                for (int j = 1; j < str2.Length; j++)
                {
                    if (st1[i] == st2[j])
                    {
                        cost = 0;
                    }
                    else
                    {
                        cost = 1;
                    }
                    _array[i, j] = Math.Min(_array[i - 1, j] + 1, Math.Min(_array[i, j - 1] + 1, _array[i - 1, j - 1] + cost));
                }
            }
            

            Console.WriteLine();
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    Console.Write("{0, 3}", _array[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
