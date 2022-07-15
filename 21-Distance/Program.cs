/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
*/

double GetDistance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    int xDistSquared = (xA - xB) * (xA - xB);
    int yDistSquared = (yA - yB) * (yA - yB);
    int zDistSquared = (zA - zB) * (zA - zB);

    return Math.Sqrt(xDistSquared + yDistSquared + yDistSquared); 
}

int GetCoordinate(string point, string axis)
{
    Console.Write($"Введите координату для точки {point} по оси {axis}: ");
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Программа для вычиления расстояния между двумя точками в 3D");

int xA = GetCoordinate("A", "X");
int yA = GetCoordinate("A", "Y");
int zA = GetCoordinate("A", "Z");

int xB = GetCoordinate("B", "X");
int yB = GetCoordinate("B", "Y");
int zB = GetCoordinate("B", "Z");

Console.WriteLine($"Расстояние между точками равно {GetDistance(xA, yA, zA, xB, yB, zB)}");