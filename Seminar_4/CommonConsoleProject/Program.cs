// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int GetSum(int number)
{
    int sum = 0;
    if (number > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            sum = sum + i;
        }
    }

    if (number < 0)
    {
        for (int i = 1; i >= number; i--)
        {
            sum = sum + i;
        }
    }

    return sum;
}


Console.Write("Imput A: ");
int a = int.Parse(Console.ReadLine());

int sum = GetSum(a);
Console.WriteLine(sum);
