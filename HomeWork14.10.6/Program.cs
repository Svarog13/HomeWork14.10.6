using System;

Console.WriteLine("Enter two digits for the range: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (b < a)
{
    int temp = a;
    a = b;
    b = temp;
}

Random random = new Random();
int randomNumber = random.Next(a, b);

Console.WriteLine("You have 3 attempts to guess the number!");

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Attempt {i}: Enter your guess: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == randomNumber)
    {
        Console.WriteLine("Congratulations, you guessed the number!");
        break;
    }
    else if (choice < randomNumber)
    {
        Console.WriteLine("The number is greater than your guess.");
    }
    else
    {
        Console.WriteLine("The number is less than your guess.");
    }

    if (i == 3)
    {
        Console.WriteLine("You've used all 3 attempts. The correct number was: " + randomNumber);
    }
}