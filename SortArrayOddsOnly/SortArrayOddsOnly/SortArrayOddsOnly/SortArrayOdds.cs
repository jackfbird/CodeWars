using System;

namespace SortArrayOddsOnly
{
    public partial class Exercises
    {
        public int[] SortArray(int[] array)
        {
            int tempNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    continue;

                for (int j = (i + 1); j < array.Length; j++)
                {
                    if (array[j] % 2 != 0)
                    {
                        if (array[i] > array[j])
                        {
                            tempNumber = array[i];
                            array[i] = array[j];
                            array[j] = tempNumber;
                        }
                    }
                }
            }
            return array;
        }
    }
}


