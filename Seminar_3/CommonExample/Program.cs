// Определение четверти точки
int GetPointArea(int x, int y) 
{
    if (x > 0 && y > 0) {
        return 1;
    }

    if (x < 0 && y > 0) {
        return 2;
    }

    if (x < 0 && y < 0) {
        return 3;
    }

    if (x > 0 && y < 0) {
        return 4;
    }

    return 0;
}

Console.Write("Input X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Inpot Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int areaNum = GetPointArea(x, y);
Console.WriteLine($"Area = {areaNum}");

