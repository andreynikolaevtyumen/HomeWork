//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100) // Проверка на наличие третьей цифры в введенном числе
{
    string str_number = number.ToString();
    char digit3 = str_number[2];

    Console.WriteLine("Третья цифра введенного числа:  ");
    
    Console.WriteLine(digit3);
}
else 
{
    Console.WriteLine("В введенном числе нет третьей цифры.");
}


