using System.Diagnostics;

namespace otusHomeWorkMultiThread
{
    public class SumThreadClass : ISum
    {
        private Stopwatch _sw = new();
        public int _countThread;

        public SumThreadClass(int countThread)
        {
            _countThread = countThread;
        }

        /// <summary>
        /// Сумма массива тасками через разбиение
        /// </summary>
        /// <param name="array"></param>
        /// <param name="countThread"></param>
        /// <returns></returns>
        public void Sum(int[] array)
        {
            var result = 0;
            var listArray = EnumerableExtensions.SplitArray(array, _countThread);
            var tasks = new List<Task<int>>();

            _sw.Reset();
            _sw.Start();

            foreach (var item in listArray)
            {
                tasks.Add(Task.Run(() => EnumerableExtensions.SumArray(item.ToArray())));
            }

            int[] results = Task.WhenAll(tasks).Result;
            result = results.Sum();

            _sw.Stop();

            Console.WriteLine("Массив размером - " + array.Length + ". Сумма - " + result + " Время выполнения - " + _sw.Elapsed.TotalSeconds);
        }
    }
}