using System;

namespace Calculator.ClassesSorts
{
    public class SelectionSort : ISort
    {
        public string Sort(string mass)
        {
           string[] split = mass.Split(new char[] {' '});
           int[] A= new int[split.Length];
           for (int i = 0; i < A.Length; i++)
           {
               A[i] = Convert.ToInt32(split[i]);
           }

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

           string g;
           for (int i = 0; i < A.Length; i++)
           {
               split[i] = A[i].ToString() + " ";
           }
           g = string.Concat(split);
           return g;
        }
    }
}