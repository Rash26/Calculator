using System;

namespace Calculator.ClassesSorts
{
    public class GnomeSort : ISort
    {
        public int[] Sort(int[] a)
        {
            int i = 0;
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
            return a;
        }
    }
}