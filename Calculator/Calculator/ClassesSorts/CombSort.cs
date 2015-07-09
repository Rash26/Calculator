namespace Calculator.ClassesSorts
{
    public class CombSort : ISort
    {
        public int[] Sort(int[] sourse)
        {
            int gap = sourse.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int)(gap / 1.247330950103979);

                int i = 0;
                swapped = false;
                while (i + gap < sourse.Length)
                {
                    if (sourse[i].CompareTo(sourse[i + gap]) > 0)
                    {
                        int t = sourse[i];
                        sourse[i] = sourse[i + gap];
                        sourse[i + gap] = t;
                        swapped = true;
                    }
                    i++;
                }
            }
            return sourse;
        }
    }
}