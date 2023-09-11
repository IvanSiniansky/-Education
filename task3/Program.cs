// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру");
string strNum = Console.ReadLine();
int dateNum = int.Parse(strNum);

if (dateNum == 6 || dateNum == 7) {
    Console.WriteLine("да - это выходной день!");
}
else if (dateNum < 1 || dateNum >7){
    Console.WriteLine("Это не день недели.");
}
else Console.WriteLine("нет - это будний день!");