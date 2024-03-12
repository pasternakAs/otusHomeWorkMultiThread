using System.Diagnostics;

namespace otusHomeWorkMultiThread
{
    public class SumNormalClass : ISum
    {
        private Stopwatch _sw = new();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        public void Sum(int[] array)
        {
            _sw.Reset();
            _sw.Start();
            var result = EnumerableExtensions.SumArray(array);
            _sw.Stop();

            Console.WriteLine("Массив размером - " + array.Length  +  ". Сумма - " + result + " Время выполнения - " + _sw.Elapsed.TotalSeconds);
        }
    }
}
