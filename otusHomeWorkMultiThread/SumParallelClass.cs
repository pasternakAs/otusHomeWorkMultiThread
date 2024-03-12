using System.Diagnostics;

namespace otusHomeWorkMultiThread
{
    public class SumParallelClass : ISum
    {
        private readonly Stopwatch _sw = new();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public void Sum(int[] array)
        {
            _sw.Reset();
            _sw.Start();
            var result = array.AsParallel().Sum();
            _sw.Stop();

            Console.WriteLine("Массив размером - " + array.Length + ". Сумма - " + result + " Время выполнения - " + _sw.Elapsed.TotalSeconds);
        }
    }
}
