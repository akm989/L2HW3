// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:  ");
string num = Convert.ToString(Console.ReadLine());

string num2 = Convert.ToString(num);

if (num2.Length > 5 || num2.Length < 5)
{
    Console.WriteLine ("Введено не пятизначное число");
}
else 
{ 
    if (num[0]==num[4] && num[1]==num[3])
{
    Console.WriteLine ($"{num} -> да");
}
    else
    {
    Console.WriteLine ($"{num} -> нет");    
    }
}