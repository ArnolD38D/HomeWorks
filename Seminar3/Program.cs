/*
// Задача №19. Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

void Palindrome (string number)
{
    
    if (number[0] == number[4] && number[1] == number[3])
    {
    Console.WriteLine ($"number {number} is a palindrome");
    }
    else 
    {
        Console.WriteLine ($"number {number} not a palindrome");
    }
}

Console.Write ("Enter a number: ");
string?number = Console.ReadLine ();
Palindrome(number);
*/

/*
// Задача №21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

double DistanceIn3dSpace (double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
    return Math.Sqrt (Math.Pow ((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
}



Console.Write ("Input X1: ");
double Xa = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Input Y1: ");
double Ya = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Input Z1: ");
double Za = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Input X2: ");
double Xb = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Input Y2: ");
double Yb = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Input Z2: ");
double Zb = Convert.ToDouble (Console.ReadLine ());
double DistanceBetweenPoints = DistanceIn3dSpace (Xa, Ya, Za, Xb, Yb, Zb);
Console.WriteLine ($"Distance is {DistanceBetweenPoints}");
*/

/*
// Задача №23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов от 1 до N.

void cube (int[] N)
{
    int Length = N.Length;
    int counter = 0;
    while (counter < Length)
    {
        N[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}
void PrintArry (int[] cool)
{
    int count = cool.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(cool[index] + " ");
        index++;
    }
}

Console.Write ("Input number N: ");
int N = Convert.ToInt32 (Console.ReadLine ());
int[] arry = new int[N+1];
cube(arry);
PrintArry(arry);

*/