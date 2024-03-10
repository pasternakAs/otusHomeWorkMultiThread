using System.Diagnostics;

namespace otusHomeWorkMultiThread
{
    public class SumNormalClass : ISum
    {
        private Stopwatch _sw = new Stopwatch();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        public void Sum(int[] array)
        {
            _sw.Start();
            var result = ArrayMethodClass.SumArray(array);
            _sw.Stop();

            Console.WriteLine("Массив размером - " + array.Length  +  ". Сумма - " + result + " Время выполнения - " + _sw.Elapsed.TotalMilliseconds);
        }
    }
}
