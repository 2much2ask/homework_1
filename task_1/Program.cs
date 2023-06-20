/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} большее, число {number2} меньшее");
}
else if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}    
else 
{
    Console.WriteLine($"Число {number2} большее, число {number1} меньшее");
}