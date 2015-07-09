namespace Calculator.ClassesSorts
{
    /// <summary>
    /// comb sort
    /// </summary>
    public class CombSort : ISort
    {
        public int[] Sort(int[] source)
        {
            int gap = source.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int)(gap / 1.247330950103979);

                int i = 0;
                swapped = false;
                while (i + gap < source.Length)
                {
                    if (source[i].CompareTo(source[i + gap]) > 0)
                    {
                        int t = source[i];
                        source[i] = source[i + gap];
                        source[i + gap] = t;
                        swapped = true;
                    }
                    i++;
                }
            }
            return source;
        }
    }
}