
/*
// Задача 1. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumberOfThree (int number)
{
    return (number / 10) % 10;
}

Console.Write ("Enter a three digit number");

int number = Convert.ToInt32(Console.ReadLine());
int Digit = SecondNumberOfThree(number);

Console.WriteLine ($"{number} the second number {Digit}");
*/

/*
// Задача 13. Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.


int MethodThirdNumber (int number)
{
        
    while (number <= -1000 || number >= 1000)
    {
        number = number / 10;    
    } 
    if (number < -99 || number >99)
    {
        number = number % 10;
    }
    else
    {
        Console.WriteLine ($"{number} There is no third number"); 
    }
        
    return number;
}
   
 Console.Write ("Enter a number: ");
 int number = Convert.ToInt32(Console.ReadLine());

 int ThreeDigit = MethodThirdNumber(number);

Console.WriteLine ($"The third number from {number} this {ThreeDigit}");
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день 
// выходным.

int TheDaysOfTheWeekMethod(int dayNumber);
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine ($"It's a day off");
    }
    else
    {
        Console.WriteLine ($"This day is not a day off")
    }
    return dayNumber;
}

Console.Write ("Enter a number indicating the day of the week: ");
 int number = Convert.ToInt32(Console.ReadLine());
 int IndicatingNumber = TheDaysOfTheWeekMethod(dayNumber);
Console.WriteLine ($"This number indicates the day of the week, which is {IndicatingNumber}");
