// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Привет я могу найти из двух чисел какое число больше, а какое меньшее");
Console.WriteLine("Введите первое число");
int namber_A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namber_B = int.Parse(Console.ReadLine());
if (namber_A == namber_B)
    Console.WriteLine("Вы ввели одинаковые числа " + namber_A + " = " + namber_B);
else
    if (namber_A > namber_B)
    Console.WriteLine("Число " + namber_A + " max" + " а число " + namber_B + " min");
else
    Console.WriteLine("Число " + namber_A + " min" + " а число " + namber_B + " max");
