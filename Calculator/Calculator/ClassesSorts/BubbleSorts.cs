using System;

namespace Calculator.ClassesSorts
{
    public class BubbleSorts : ISort
    {
       public string Sort(string mass)
       {
           string[] split = mass.Split(new char[] {' '});
           int[] A= new int[split.Length];

           for (int i = 0; i < A.Length; i++)
           {
               A[i] = Convert.ToInt32(split[i]);
           }


            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[i])
                    {
                        var temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
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