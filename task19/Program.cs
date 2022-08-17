// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());


string NumberText = Convert.ToString(Number);


if (NumberText[0]==NumberText[4] & NumberText[1]==NumberText[3]) 
{
    Console.WriteLine ("Число " + Number + " является палиндромом");
}

else
{
    Console.WriteLine ("Число " + Number + " не является палиндромом");
}