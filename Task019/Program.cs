// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Polindrome()
{

Console.WriteLine("Введите пятизначное чило и узнайте является ли оно полнидромом: ");
int number = Convert.ToInt32(Console.ReadLine());


    if (number <= 9999)
    {
        Console.WriteLine("Введите пятизначное число и перезапустите программу");
    } 
    else
    {
        string str_number = number.ToString();
        char digit1 = str_number[0];
        char digit2 = str_number[1];
        char digit4 = str_number[3];
        char digit5 = str_number[4];

         if (digit1 == digit5 && digit2 == digit4)
         {
            Console.WriteLine("Введенное пятизначное число является полиндромом");
         }
         else
         {
            Console.WriteLine("Введенное пятизначное число не является полиндромом");
         }
    }
}

Polindrome();


    
