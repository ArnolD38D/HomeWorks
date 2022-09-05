
/*
// Задача 34: Задайте массив заполненный случайными положительными 
// трехзначными числами. Напишите программу, которая покажет 
// количество четных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("массив:");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers [z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int number, int min, int max)
  {
  int[] randomNumbers = new int[number];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(number, 1, 10);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");
*/

/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

double[] arrayRealNumbers = new double[5];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + ", ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"Разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
  */