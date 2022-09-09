// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int GetCountDigit(int number)
{
    // Количество цифр в числе
    int countDigit = 0;

    // Временная переменная для хранения входного значения
    int tempNumber = Math.Abs(number);

    // Подсчет цифр в входном числе
    while (tempNumber != 0)
    {
        // Избавление от правой крайней цифры
        tempNumber = tempNumber / 10;

        // Увеличение счетка на 1
        countDigit++;
    }

    // Возврат результата
    return countDigit;
}

Console.Write("Imput A: ");
int a = int.Parse(Console.ReadLine());

int countDigit = GetCountDigit(a);
Console.WriteLine($"Количество цифр в числе {a}: {countDigit}");

