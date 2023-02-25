// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Решение. 

Console.Clear();

//Инициализация массивов.
int[,] array = GetArray(4, 4);

//Вывод массивов на консоль.
PrintArray(array);

int[,] GetArray(int rows, int colum) //Данный метод создает двух мерный массив и заполняет рандомными числами.
{
  int[,] res = new int[rows, colum];
  for (int i = 0; i < res.GetLength(0); i++)
  {
    for (int j = 0; j < res.GetLength(1); j++)
    {
      res[i, j] = new Random().Next(1, 9);
    }
  }
  return res;
}

//В данном цикле перебераю строку с наименьшей суммой элементов и вывожу на консоль строку.
int minNumString = 0;
int numString = SumElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumString = SumElement(array, i);
  if (numString > tempSumString)
  {
    numString = tempSumString;
    minNumString = i;
  }
}

//Вывод строки с наименьшей суммой на консоль.
Console.WriteLine($"\nНомер строки с наименьшей суммой элементов -> {minNumString + 1}");

int SumElement(int[,] elements, int i) //В данном методе я ищу строку с наименьшей суммой элементов.
{
  int minSum = elements[i, 0];
  for (int j = 1; j < elements.GetLength(1); j++)
  {
    minSum = elements[i, j] + minSum;
  }
  return minSum;
}

void PrintArray(int[,] inArray) //Данный метод выводит на консоль массив.
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
}
