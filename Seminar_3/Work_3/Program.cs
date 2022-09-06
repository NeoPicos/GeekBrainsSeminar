/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N. */
int[] GetSquaresNumer(int numer)
{
    int[] squaresNumers = new int[numer];

    // Заполнение массива результата
    for (int i = 1; i <= numer; i++)
    {
        squaresNumers[i - 1] = i * i;
    }

    return squaresNumers;
}

Console.Write("Input name: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetSquaresNumer(num);
for (int i = 0; i < result.Length; i++) {
    Console.WriteLine(result[i]);
}
