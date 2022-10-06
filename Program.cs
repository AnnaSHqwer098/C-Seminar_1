// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

if (a > b) {
    Console.WriteLine($"{a} - большее число, {b} - меньшее число");
}
else if (a < b) {
    Console.WriteLine($"{a} - меньшее число, {b} - большее число");
}
else {
    Console.WriteLine($"Первое число = второму числу = {a}");
} 
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine()!);

if (a > b && a > c) {
    Console.WriteLine($"Максимальное число - {a}");
}
else if (b > a && b > c) {
        Console.WriteLine($"Максимальное число - {b}");
}
else if (c > a && c > b) {
        Console.WriteLine($"Максимальное число - {c}"); 
}
else {
    Console.WriteLine($"Первое число = второму числу = третьему числу = {a}");
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a %2 == 0) {
    Console.WriteLine("Введенное число является четным");
}
else {
    Console.WriteLine("Введенное число не является четным");
}
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число больше 1");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while (i <= N) {
    if (i %2 == 0) {
        Console.Write($"{i}, ");
    }
    i++;
}