using otusHomeWorkMultiThread;
using System.Diagnostics;


Console.WriteLine("Начнем!");
const int sizeSmall = 100000;
const int sizeNormal = 1000000;
const int sizeLarge = 10000000;

var _arrayIntSmall = EnumerableExtensions.CreateArrayInt(sizeSmall);
var _arrayIntNormal = EnumerableExtensions.CreateArrayInt(sizeNormal);
var _arrayIntLarge = EnumerableExtensions.CreateArrayInt(sizeLarge);


var sumNormal = new SumNormalClass();
Console.WriteLine();
Console.WriteLine(@"Обычное сложение: ");

sumNormal.Sum(_arrayIntSmall);
sumNormal.Sum(_arrayIntNormal);
sumNormal.Sum(_arrayIntLarge);

Console.WriteLine(@"");


Console.WriteLine("Введите число потоков - ");
var countThread = Convert.ToInt32(Console.ReadLine());
var sumThread = new SumThreadClass(countThread);
Console.WriteLine(@"Параллельное на " + countThread + " : ");
sumThread.Sum(_arrayIntSmall);
sumThread.Sum(_arrayIntNormal);
sumThread.Sum(_arrayIntLarge);

Console.WriteLine();
Console.WriteLine("Введите число потоков - ");
countThread = Convert.ToInt32(Console.ReadLine());
var sumThread1 = new SumThreadClass(countThread);
Console.WriteLine(@"Параллельное на " + countThread + " : ");
sumThread1.Sum(_arrayIntSmall);
sumThread1.Sum(_arrayIntNormal);
sumThread1.Sum(_arrayIntLarge);

Console.WriteLine(@"");
var sumParallel = new SumParallelClass();
Console.WriteLine(@"Параллельное с помощью LINQ: ");
sumParallel.Sum(_arrayIntSmall);
sumParallel.Sum(_arrayIntNormal);
sumParallel.Sum(_arrayIntLarge);

Console.ReadLine();