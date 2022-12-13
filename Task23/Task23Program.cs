//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Методы
void Cube(int number)
{
    number = number*number*number;
    Console.WriteLine(number + ", ");
}


int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int n = EnterData("Введите число:()");
int i = 1;
while(i<=n)
{
    Cube(i);
    i++;
}
