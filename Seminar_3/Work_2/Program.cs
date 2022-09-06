// Получение расстояния между двумя точками на плоскости
double GetDistanceTwoPoint(int x1, int y1, int x2, int y2) 
{
    double distanse = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

    return distanse;
}

Console.Write("Введите X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите Y2: ");
int y2 = int.Parse(Console.ReadLine());

// Расчет расстояния между двумя точками на плоскости
double result = GetDistanceTwoPoint(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");
