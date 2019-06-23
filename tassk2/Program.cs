using System;

namespace tassk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int el = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            string[] elements = str.Split(' ');
            int[] mas = new int[el];
            for (int l = 0; l < el; l++)
            {
                mas[l] = Convert.ToInt32(elements[l]);
            }
            int[,] m = new int[2, el / 2];
            int x = 0;
            int g = 0;
            int max = -1;
            bool ok = false;
            for (int i = 0; i < el; i++)
            {
                for (int t = 0; t < el / 2; t++)
                {
                    if (m[0, t] == mas[i])
                    {
                        ok = true;
                        x = t;
                        break;
                    }
                    else ok = false;
                }
                if (ok == true)
                {
                    int ind = m[1, x];

                    int dif = i - ind;
                    if (dif > max) max = dif;
                    m[1, x] = i;
                }
                else
                {
                    m[0, g] = mas[i];
                    m[1, g] = i;
                    g++;
                }
            }
            Console.WriteLine(max);
            //Console.ReadKey();
        }
    }
}
