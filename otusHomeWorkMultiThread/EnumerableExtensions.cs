namespace otusHomeWorkMultiThread
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Создать и заполнить массив
        /// </summary>
        /// <param name="length">размер массива</param>
        /// <returns></returns>
        public static int[] CreateArrayInt(int length)
        {
            int Min = 0;
            int Max = 40;
            var randNum = new Random();

            return Enumerable
                .Repeat(0, length)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();
        }

        /// <summary>
        /// Сложение массива
        /// </summary>
        /// <param name="array">массив</param>
        /// <returns></returns>
        public static int SumArray(int[] array)
        {
            var sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        /// <summary>
        /// Разбить массив на части
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="countParts"></param>
        /// <returns></returns>
        public static List<T[]> SplitArray<T>(T[] array, int countParts)
        {
            var sizeArray = array.Length / countParts;
            var list = array.Chunk(sizeArray).ToList();

            return list;
        }
    }
}