using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkMultiThread
{
    public class SumParallelClass : ISum
    {
        private Stopwatch _sw = new Stopwatch();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public void Sum(int[] array)
        {
            _sw.Start();
            var result = array.AsParallel().Sum();
            _sw.Stop();

            Console.WriteLine("Массив размером - " + array.Length + ". Сумма - " + result + " Время выполнения - " + _sw.Elapsed.TotalMilliseconds);
        }
    }
}
