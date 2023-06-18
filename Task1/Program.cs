// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int DigitNumber(int num1)
{
    int index = 1;
    while (num1 / 10 != 0)
    {
        num1 /= 10;
        index *= 10;
    }
    return index;
}

int InvertNum(int num2, int index1)
{
    int temp = 0;
    while (num2 != 0)
    {
        temp = temp + (num2 % 10) * index1;
        index1 /= 10;
        num2 /= 10;
    }
    return temp;

}

int number = InputNum("Введите целoе число: ");
int ind = DigitNumber(number);
int invertnumber = InvertNum(number, ind);
Console.WriteLine($"{invertnumber}-перевернутое число");

if (number == invertnumber)
    Console.WriteLine($"Число {number} является палиндромом");
else
    Console.WriteLine($"Число {number} не является палиндромом");
