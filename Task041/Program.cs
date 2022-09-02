// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Пользователь устанавливает размер массива.
Console.Write($"Введи размер массива (число М): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

// Метод для заполнения массива.
void FillArray(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

// Метод для определения положительных чисел и их количества.
int PositiveNumber(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

FillArray(m);

Console.WriteLine($"Массив содержит элементов больше 0: {PositiveNumber(array)}");