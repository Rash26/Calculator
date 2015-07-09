using System;

namespace Calculator.ClassesSorts
{
    public class GnomeSort : ISort
    {
        public string Sort(string mass)
        {
            string[] split = mass.Split(new char[] { ' ' });
            int[] a = new int[split.Length];
            int i;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(split[i]);
            }

            i = 0;
            while (i < a.Length)
            {
                if (i == 0 || a[i - 1] <= a[i])
                    i++;
                else
                {
                    int temp = a[i];
                    a[i] = a[i - 1];
                    a[i - 1] = temp;
                    i--;
                }
            }

            string g;
            for (i = 0; i < a.Length; i++)
            {
                split[i] = a[i].ToString() + " ";
            }
            g = string.Concat(split);
            return g;
        }
    }
}