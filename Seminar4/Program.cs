
/*
// Задача №25. Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
int Exponentiation (int numberA, int numberB)
{
    int result = Convert.ToInt32(Math.Pow(numberA, numberB));
    return result;
}

Console.Write("Enter the number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int Inkind = Exponentiation(numberA, numberB);
Console.WriteLine($" = {Inkind}");
*/

/*
// Задача №27. Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int SumNumber(int numberN)
{
    int counter=Convert.ToString(numberN).Length;
    int advance=0;
    int result=0;
    for(int i=0; i<counter; i++)
    {
        advance=numberN-numberN % 10;
        result=result + (numberN-advance);
        numberN=numberN / 10;
    }
    return result;
}
Console.Write("Enter number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"The sum of the numbers in the number N: {SumNumber(numberN)}");
*/
/*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

int[] CreateArray (int saze)
{
    int[] newArray = new int [saze];
    for (int i = 0; i < saze; i++)
    {
        Console.Write($"Input {i} element of the array: ");
        newArray [i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
Console.Write ("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(a);
ShowArray(myArray);
*/

