// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первой число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.Write("max = ");
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(thirdNumber);
    } 
}
else
{
    if (secondNumber > thirdNumber)
    {
        Console.Write("max = ");
        Console.WriteLine(secondNumber);
    }
    else
    {
        Console.Write("max = ");
        Console.WriteLine(thirdNumber);  
    }
}