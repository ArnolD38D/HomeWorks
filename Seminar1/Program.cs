/*
// Задача №2. Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write ("Input first number: ");
int num_A = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Input second number: ");
int num_B = Convert.ToInt32 (Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine ($"{num_A} more than {num_B} ");
}
else
{
    Console.WriteLine ($"{num_B} more than {num_A} ");
}
*/

/*
// Задача №4. Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
  
Console.WriteLine ("enter three numbers! ");

int num_1 = Convert.ToInt32 (Console.ReadLine());
int num_2 = Convert.ToInt32 (Console.ReadLine());
int num_3 = Convert.ToInt32 (Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}

if (num_3 > max)
{
    max = num_3;
}

Console.WriteLine ($"The largest of the entered numbers {max} ");

*/

/*
// Задача №6. Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Enter a number! ");
double number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine($"{number} not even ");
}

else
{
    Console.WriteLine($"{number} even ");
}
*/

/*
// Задача №8. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter a number!");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;
Console.WriteLine($"Even numbers from 1 before {N} ");
while (i <=N)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("there are no even numbers! ");
}

*/