//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 5)
{
    Console.WriteLine("В пятницу я - мусульманин. Выходной!");
}
else if (number == 6)
{
    Console.WriteLine("В субботу я - иудей. Праздную!");
}

else if (number == 7)
{
    Console.WriteLine("В воскресенье я - истинный христианин. Отдыхаю!");
}
else
{
    Console.WriteLine("Рабочий день, но работать все равно неохота...");
}