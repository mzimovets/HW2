// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int inputInt(string message)
{
    System.Console.Write(message + ": ");
    string? intputValue = Console.ReadLine();
    int result = Convert.ToInt32(intputValue); 
    return result; 
}

bool ValidNumber(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное!");
    return false;
}

int number = inputInt("Введите трехзначное число");

if (ValidNumber(number))
{
    int funcNum = number % 100;
    int secondRank = funcNum / 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {secondRank}");
}
