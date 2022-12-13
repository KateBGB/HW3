//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Методы
double Distance3D (int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2));
    return result;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Решение
int xa = EnterData("Введите координату xa:()");
int ya = EnterData("Введите координату ya:()");
int za = EnterData("Введите координату za:()");
int xb = EnterData("Введите координату xb:()");
int yb = EnterData("Введите координату yb:()");
int zb = EnterData("Введите координату zb:()");
double result = Distance3D(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками a и b составляет {result}");


