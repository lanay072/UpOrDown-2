Console.WriteLine("Введи число от 1 до 100");
Random random= new Random();
int SN = random.Next(1, 100);
int guess;
int attempts = 0;
bool success = int.TryParse(Console.ReadLine(), out guess);
while (guess != SN)
{
    if (!success)
    {
        Console.WriteLine("Бля какой ты ебень");
        success = int.TryParse(Console.ReadLine(), out guess);
        if (success)
        {
            attempts += 1;
        }
    }
    else
    {
        if (guess > SN)
        {
            Console.WriteLine("Попробуй число меньше");
            success = int.TryParse(Console.ReadLine(), out guess);
            if(success)
            {
                attempts += 1;
            }
        }

        else if (guess < SN)
        {
            Console.WriteLine("Попробуй число больше");
            success = int.TryParse(Console.ReadLine(), out guess);
            if (success)
            {
                attempts += 1;
            }
        }
    }
}
Console.WriteLine("Угадал!");
Console.WriteLine($"Колличество попыток - {attempts}");
