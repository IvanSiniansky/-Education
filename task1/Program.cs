// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456-> 5
// 782-> 8
// 918-> 1

Console.WriteLine("Введите трёхзначное число");
int treeNum = Convert.ToInt32(Console.ReadLine());
string strNum = Convert.ToString(treeNum);
Console.WriteLine("вторая цифра этого числа -> "+strNum[1]);