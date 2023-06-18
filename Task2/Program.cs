// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double InputNum(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double Distance(double numX1, double numY1, double numZ1, double numX2, double numY2, double numZ2)
{
    double res = Math.Sqrt(Math.Pow((numX1 - numX2), 2) + Math.Pow((numY1 - numY2), 2) + Math.Pow((numZ1 - numZ2), 2));
    return res;
}

double numberX1 = InputNum("Введите координату X точки 1: ");
double numberY1 = InputNum("Введите координату Y точки 1: ");
double numberZ1 = InputNum("Введите координату Z точки 1: ");
double numberX2 = InputNum("Введите координату X точки 2: ");
double numberY2 = InputNum("Введите координату Y точки 2: ");
double numberZ2 = InputNum("Введите координату Z точки 2: ");
double result = Math.Round(Distance(numberX1, numberY1, numberZ1, numberX2, numberY2, numberZ2), 2);
Console.WriteLine($"Расстояние между точками 1 и 2 = {result}");