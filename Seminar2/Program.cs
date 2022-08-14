
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


// Задача 13. Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

int MethodThirdNumber (int number)
{
    while (number >= 1000)
    {
        number = number / 10;    
    } 
    while (number <= -1000)
    {
        number = number / 10;    
    } 
    if (number > 99)
    {
        number = number % 10;
    }
        
    if (number < -99)
    {
        number = number % 10;
    }
    
        else
            Console.WriteLine ("Here is no third digit"); 
return number;
}

 Console.Write ("Enter a number: ");
 int number = Convert.ToInt32(Console.ReadLine());

 int ThreeDigit = MethodThirdNumber(number);

Console.WriteLine ($"The third number from {number} this {ThreeDigit}");

