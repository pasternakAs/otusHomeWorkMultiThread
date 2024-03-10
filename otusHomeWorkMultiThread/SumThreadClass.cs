using System.Diagnostics;

namespace otusHomeWorkMultiThread
{
    public class SumThreadClass : ISumThread
    {
        private Stopwatch _sw = new Stopwatch();

        /// <summary>
        /// Сумма массива тасками через разбиение
        /// </summary>
        /// <param name="array"></param>
        /// <param name="countThread"></param>
        /// <returns></returns>
        public void Sum(int[] array, int countThread)
        {
            var result = 0;
            var listArray = ArrayMethodClass.SplitArray(array, countThread);
            var tasks = new List<Task<int>>();

            _sw.Restart();
            _sw.Start();

            foreach (var item in listArray)
            {
                tasks.Add(Task.Run(() => ArrayMethodClass.SumArray(item.ToArray())));
            }

            int[] results = Task.WhenAll(tasks).Result;
            result = results.Sum();

            _sw.Stop();

            Console.WriteLine("Массив размером - " + array.Length + ". Сумма - " + result + " Время выполнения - " + _sw.Elapsed.TotalMilliseconds);
        }
    }
}