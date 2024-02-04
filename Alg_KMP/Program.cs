using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alg_KMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Формирование массива p для сдвига по префиксам
            string t = "лилила";
            int j = 0;
            int i = 1;
            int[] p = new int[t.Length];

            while(i < t.Length)
            {
                if (t[j] == t[i])
                {
                    p[i] = j + 1;
                    i++;
                    j++;
                }
                else
                {
                    if (j == 0)
                    {
                        p[i] = 0;
                        i++;
                    }
                    else
                    {
                        j = p[j - 1];
                    }    
                    
                }  
            }
            /*for (int k = 0; k < p.Length; k++)
            {
                Console.Write(p[k]);
            }
            Console.ReadKey();*/

            //Поиск образа в строке
            string a = "лилила лилилось";
            int[] m = new int[t.Length];
            int[] n= new int[a.Length];

            int x = 0;
            int y = 0;
            while (x<n.Length)
            {
                if (a[x] == t[y])
                {
                    x++;
                    y++;
                    if (y == m.Length)
                    {
                        Console.WriteLine("Образ найден");
                        break;
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        y = p[y - 1];
                    }
                    else
                    {
                        x++;
                    }
                }
                
            }
            if (x == n.Length)
            {
                Console.WriteLine("Образ не найдне");
            }
            Console.ReadKey();
        }
    }
}
