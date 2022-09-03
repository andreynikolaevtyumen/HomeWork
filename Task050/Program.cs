// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задаем параметры двухмерного массива.
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");
Console.WriteLine("-->");

// Создаем двухмерный массив.
double[,] array = new double[m, n];

void CreateArray(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

// Метод для вывода массива в консоль.
void WriteArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

CreateArray(array);
WriteArray(array);

// Вводим индекс элемента массива.
Console.Write("Введите индексы элемента, разделенных запятой: ");

string? positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] index = ParserString(positionElement);

// Определение значения элемента массива по указанному индексу.
if(index[0] <= m 
&& index[1] <= n 
&& index[0] >= 0 
&& index[1] >= 0) 
{
  double result = array[index[0], index[1]];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого элемента в массиве нет.");

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}
Console.WriteLine();