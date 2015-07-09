using System;

namespace Calculator.ClassesSorts
{
    public class SelectionSort : ISort
    {
        public int[] Sort(int[] A)
        {
           for (int i = 0; i < A.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }
                int dummy = A[i];
                A[i] = A[min];
                A[min] = dummy;
            }
            return A;
        }
    }
}