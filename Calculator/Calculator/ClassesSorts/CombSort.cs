using System;

namespace Calculator.ClassesSorts
{
    public class CombSort : ISort
    {
        public int[] Sort(int[] A)
        {
            int gap = A.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int)(gap / 1.247330950103979);

                int i = 0;
                swapped = false;
                while (i + gap < A.Length)
                {
                    if (A[i].CompareTo(A[i + gap]) > 0)
                    {
                        int t = A[i];
                        A[i] = A[i + gap];
                        A[i + gap] = t;
                        swapped = true;
                    }
                    i++;
                }
            }
            return A;
        }
    }
}