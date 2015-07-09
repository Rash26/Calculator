namespace Calculator.ClassesSorts
{
    public class BubbleSorts : ISort
    {
       public int[] Sort(int[] source)
       {
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = i + 1; j < source.Length; j++)
                {
                    if (source[j] < source[i])
                    {
                        var temp = source[i];
                        source[i] = source[j];
                        source[j] = temp;
                    }
                }
            }
           return source;
       }
    }
}