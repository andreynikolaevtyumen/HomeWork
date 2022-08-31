//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
//[3 7 22 2 78] -> 76

//Заполнить массив случайными числами
int[] array = new int[5]; //Ограничиваем размер массива 5-ю элементами
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(-10, 10); //Диапозон выбора элементов массива

//Нвходим максимальное и минимальное значения элементов массива
int max = 0;
int min = 0;
for (int n = 0; n < array.Length; n++)
    if (array[n] > max)
    {
        max = array[n];
    }
for (int n = 0; n < array.Length; n++)
    if (array[n] < min)
    {
        min = array[n];
    }

int diff = max - min;

//Выводим массив и разницу максимального и минимального значений элементов массива    
var str = string.Join(" ", array);
Console.WriteLine(str);
Console.WriteLine(diff);