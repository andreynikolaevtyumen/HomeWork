﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите любое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000) // Проверка на трехзначность введенного числа
{
    int number1 = number / 100; // Находим первую цифру в трехзначном числе
    int number2 = number - (number1 * 100); // Убираем первую цифру в трехзначном числе
    int number3 = number2 % 10; // Находим последнюю цифру в трехзначном числе
    Console.WriteLine("Вторая цифра введенного трехзначного числа: "); // Выводим значение второй цифры в веденном трехзначном числе
    
    Console.WriteLine((number2 - number3)/10);
}
else 
{
    Console.WriteLine("Введенное число не являеттсяте ТРЕХЗНАЧНЫМ!!!. Повторите ввод. ");
}
