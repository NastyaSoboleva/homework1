// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число первое ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число второе ");
int numberB = int.Parse(Console.ReadLine()!);
while (numberA > numberB)
      Console.WriteLine($"Максимальное число равно {numberA}");
{
    if (numberA < numberB)
    {
        Console.WriteLine($"максимальное число равно {numberB}");
    }
    
}