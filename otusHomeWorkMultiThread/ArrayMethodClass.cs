namespace otusHomeWorkMultiThread
{
    public static class ArrayMethodClass
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
            try
            { 
                return array.Sum();
            }
            catch (OverflowException ov)
            {
                return -1;
            }
        }

        /// <summary>
        /// Разбить массив на части
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="countParts"></param>
        /// <returns></returns>
        public static List<List<T>> SplitArray<T>(T[] array, int countParts)
        {
            var list = new List<List<T>>();
            var sizeArray = array.Length / countParts;

            for (int i = 0; i < countParts; i++)
            {
                if (i == countParts - 1)
                {
                    var size = array.Skip(i * sizeArray).Count();
                    list.Add(array.Skip(i * sizeArray).Take(size).ToList());
                }
                else
                {
                    list.Add(array.Skip(i * sizeArray).Take(sizeArray).ToList());
                }
            }

            return list;
        }
    }
}