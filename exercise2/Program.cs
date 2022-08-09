// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Привет я могу найти из трех чисел какое самое больше :)");
int[] massiv = new int[3];
int max = 0;
for (int i = 0; i < massiv.Length; i++)
{ Console.WriteLine("Введите " + (i+1) +" число");
massiv[i] = int.Parse(Console.ReadLine());
if (i == 0)  max = massiv[i]; 
else 
{
if (massiv[i] > max) max = massiv[i];
 }
}
Console.WriteLine("Максимальнон число введенное вами "+ max);
