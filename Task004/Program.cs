// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число из трех: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число из трех: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число из трех: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное число из трех введенных чисел: ");
if (number1 >= number2 && number1>=number3)
{
   Console.WriteLine(number1);
}
else if (number2>number1 && number2>number3)
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine(number3);
}
