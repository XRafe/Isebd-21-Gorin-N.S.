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
        public void GeneralTr(int x, int snFirst)
        {
            for (int j = 0; x > 0; j++)
            {
                int temp = 0;
                temp = x % 10;
                x = x / 10;
                for (int l = 0; l<j; l++)
                {
                    temp *= temp;
                }
                num += temp;
            }

        }

        public void TrInSn(int snEnd)
        {
            for (i = 0; num > 1; i++)
            {
                a[i] = num % snEnd;
                num = num / snEnd;
            }
            
            for (i--; i >= 0; i--)
            {
                if (a[i]<10)
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

            Console.WriteLine(str);
        }
    }
}
