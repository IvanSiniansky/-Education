// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Prompt(string message)
// {
//     System.Console.WriteLine(message);
//     int numberN = Convert.ToInt32(Console.ReadLine());
//     return numberN;
// }

// int SumAllDigit(int numberN)
// {
//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = numberN - numberN % 10;
//       result = result + (numberN - advance);
//       numberN = numberN / 10;
//     }
//    return result;
// }

// int sumNumber = Prompt("Введите число:");
// System.Console.WriteLine($"Сумма всех числе в цифре {sumNumber} -> {SumAllDigit(sumNumber)}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int Prompt(string message) //Метод для ввода значений с клавиатуры
{
    System.Console.WriteLine(message);
    int numberThree = Convert.ToInt32(Console.ReadLine());
    return numberThree;
}

int[] GenerateArray(int Length, int minValue, int maxValue) //Инициализация масива рандомными значениями 
{
    int [] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i <Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int ParityCheck( int [] array) //Проверка чисел массива на четность
{
    int num = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] % 2 == 0){
            num += 1;
        } 
    }
    return num;
}

void PrintArray(int[] array) //Вывод масива на экран
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного трехзначного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного трехзначного числа: ");
int[] array = GenerateArray(length, min, max);
int a = ParityCheck(array);

PrintArray(array);
System.Console.WriteLine("Количество четных чисел в масиве -> " + a);
