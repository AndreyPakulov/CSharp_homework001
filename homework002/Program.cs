//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//  какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первой число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber > firstNumber)
{
    Console.Write("max = ");
    Console.WriteLine(secondNumber);
    Console.Write("min = ");
    Console.WriteLine(firstNumber);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(firstNumber);
    Console.Write("min = ");
    Console.WriteLine(secondNumber);
}