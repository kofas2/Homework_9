// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от M ({num}) до N ({num2}) равна {Summa(num, num2)}");

int Summa(int num, int num2)
{
    if (num == num2) return num;
    return num2 + Summa(num, num2-1);
}