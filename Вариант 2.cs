
// Решение методом сужения интервала поиска и генерации рандомного числа.


using System;

class Program
{
    static void Main()
    {
        int lowerBound = 0;
        int upperBound = 100;
        int secretNumber = GetRandomNumber(lowerBound, upperBound);

        while (true)
        {
            int gg = (lowerBound + upperBound) / 2;
            Console.WriteLine($"Предполагаемое число: {gg}");

            if (gg == secretNumber)
            {
                Console.WriteLine($"Угаданное число: {gg}");
                break;
            }
            else if (gg < secretNumber)
            {
                lowerBound = gg + 1;
            }
            else
            {
                upperBound = gg - 1;
            }
        }
    }

    static int GetRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
}