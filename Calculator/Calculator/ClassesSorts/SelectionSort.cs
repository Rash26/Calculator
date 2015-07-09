namespace Calculator.ClassesSorts
{
    /// <summary>
    /// selection sort
    /// </summary>
    public class SelectionSort : ISort
    {
        public int[] Sort(int[] sourse)
        {
           for (int i = 0; i < sourse.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < sourse.Length; j++)
                {
                    if (sourse[j] < sourse[min])
                    {
                        min = j;
                    }
                }
                int dummy = sourse[i];
                sourse[i] = sourse[min];
                sourse[min] = dummy;
            }
            return sourse;
        }
    }
}