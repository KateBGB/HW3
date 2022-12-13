//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("Введите пятизначное число");
int a = number/10000;
int b = number % 10;
int c = (number/1000) % 10;
int d = (number/10) % 10;
if (a==b && c==d)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
   Console.WriteLine($"Число {number} не является палиндромом"); 
}

