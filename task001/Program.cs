// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Решение.
Console.Clear();

//Инициализация массивов.
int[,] array = NewArray(4, 4);

//Вывод массивов на консоль.
PrintArray(array);
ArrangeElements(array);
Console.WriteLine();
PrintArray(array);

int[,] NewArray(int rows, int colum) //Данный метод создает двух мерный массив и заполняет рандомными числами.
{
  int[,] result = new int[rows, colum];
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = new Random().Next(10, 99);
    }
  }
  return result;
}

void ArrangeElements(int[,] elements) //В данном методе я перебераю массив.
{
  int figure = 0;
  for (int i = 0; i < elements.GetLength(0); i++)
  {
    for (int j = 0; j < elements.GetLength(1); j++)
    {
      for (int k = 0; k < elements.GetLength(1) - 1; k++)
      {
        if (elements[i, k] < elements[i, k + 1])
        {
          figure = elements[i, k + 1];
          elements[i, k + 1] = elements[i, k];
          elements[i, k] = figure;
        }
      }
    }
  }
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