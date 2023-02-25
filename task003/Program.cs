// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Решение.

Console.Clear();

//Инициализация массивов.
int[,] firstArray = GetArray(2, 2);
int[,] secomdArray = GetArray(2, 2);
int[,] resultMatrix = GetArray(2, 2);

ProductMatrices(firstArray, secomdArray, resultMatrix);

//Вывод массивов на консоль.
Console.WriteLine("Первая матрица: ");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(secomdArray);
Console.WriteLine();
Console.WriteLine("произведение двух матриц: ");
PrintArray(resultMatrix);



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

void ProductMatrices(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix) //Данный метод находит произведение двух матриц и записывает результат в двухмерный массив.
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int t = 0; t < resultMatrix.GetLength(1); t++)
      {
        sum += firstMatrix[i, t] * secondMatrix[t, j];
      }
      resultMatrix[i, j] = sum;
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
