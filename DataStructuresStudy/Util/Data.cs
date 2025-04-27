namespace DataStructuresStudy.Util
{
    public static class Data
    {
        public static int[] GenerateRandomArray(
            int size = 10000,
            int minValue = int.MinValue,
            int maxValue = int.MaxValue
        )
        {
            Random random = new();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }
    }
}
