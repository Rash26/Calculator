namespace Calculator.ClassesSorts
{
    public class GnomeSort : ISort
    {
        public int[] Sort(int[] sourse)
        {
            int i = 0;
            while (i < sourse.Length)
            {
                if (i == 0 || sourse[i - 1] <= sourse[i])
                    i++;
                else
                {
                    int temp = sourse[i];
                    sourse[i] = sourse[i - 1];
                    sourse[i - 1] = temp;
                    i--;
                }
            }
            return sourse;
        }
    }
}