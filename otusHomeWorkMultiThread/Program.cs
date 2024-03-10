using otusHomeWorkMultiThread;
using System.Diagnostics;


Console.WriteLine("Начнем!");
const int sizeSmall = 100000;
const int sizeNormal = 1000000;
const int sizeLarge = 10000000;

var _arrayIntSmall = ArrayMethodClass.CreateArrayInt(sizeSmall);
var _arrayIntNormal = ArrayMethodClass.CreateArrayInt(sizeNormal);
var _arrayIntLarge = ArrayMethodClass.CreateArrayInt(sizeLarge);


var sumNormal = new SumNormalClass();
Console.WriteLine();
Console.WriteLine(@"Обычное сложение: ");

sumNormal.Sum(_arrayIntSmall);
sumNormal.Sum(_arrayIntNormal);
sumNormal.Sum(_arrayIntLarge);

Console.WriteLine(@"");

var sumThread = new SumThreadClass();
Console.WriteLine("Введите число потоков - ");
var countThread = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@"Параллельное на " + countThread + " : ");
sumThread.Sum(_arrayIntSmall, countThread);
sumThread.Sum(_arrayIntNormal, countThread);
sumThread.Sum(_arrayIntLarge, countThread);

Console.WriteLine();
Console.WriteLine("Введите число потоков - ");
countThread = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(@"Параллельное на " + countThread + " : ");
sumThread.Sum(_arrayIntSmall, countThread);
sumThread.Sum(_arrayIntNormal, countThread);
sumThread.Sum(_arrayIntLarge, countThread);

Console.WriteLine(@"");
var sumParallel = new SumParallelClass();
Console.WriteLine(@"Параллельное с помощью LINQ: ");
sumParallel.Sum(_arrayIntSmall);
sumParallel.Sum(_arrayIntNormal);
sumParallel.Sum(_arrayIntLarge);

Console.ReadLine();