// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите число - первый элемент массива из восьми элементов: ");
int array0 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - второй элемент массива из восьми: ");
int array1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - третий элемент массива из восьми: ");
int array2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - четвертый элемент массива из восьми: ");
int array3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - пятый элемент массива из восьми: ");
int array4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - шестой элемент массива из восьми: ");
int array5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - седьмой элемент массива из восьми: ");
int array6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число - восьмой элемент массива из восьми: ");
int array7 = Convert.ToInt32(Console.ReadLine());

int [] array = {array0, array1, array2, array3, array4, array5, array6, array7};

// функция  вывода массива на печать 
void PrintArry(int[] array)
{
  int count = array.Length;
  int index = 0;
  Console.Write("Массив [");
  while(index < count)
  {
    Console.Write(array[index]);
    index++;
    if (index < count)
    {
     Console.Write(", ");
    }
  }
  Console.Write("]");
} 

PrintArry(array);
Console.WriteLine(".");