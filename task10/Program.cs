// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количесто элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());;
int[] Numbers = new int[m];

void FillArrayNumbers(int m)
{
    for(int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        Numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int kol(int[] numbers)
{
int i=0;
int sum = 0;
while (i < Numbers.Length)
{
if(Numbers[i]>0)
sum = sum + 1;
i++;
}
return sum;
}

FillArrayNumbers(m);
Console.Write($"\n Чисел больше нуля: {kol(Numbers)}");

