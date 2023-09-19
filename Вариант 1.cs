using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(0, 101);
        int attempts = 0;

        Console.WriteLine("Угадай число от 0 до 100");
        
        while (attempts < 7)
        {
            Console.Write("Введите ваше число: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == targetNumber)
            {
                Console.WriteLine("Угадал, Харош!");
                return;
            }
            else
            {
                Console.WriteLine("Не угадал, не судьба");

                if (guess > targetNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число больше.");
                }

                attempts++;
            }
        }

        Console.WriteLine("7 попыток прошло, чтож такое то(())");
    }
}