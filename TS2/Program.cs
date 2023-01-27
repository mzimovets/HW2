//Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int InputInt(string message)
{
    System.Console.Write(message + ": ");
    string? InputValue = Console.ReadLine();
    int result = Convert.ToInt32(InputValue);
    return result;
}

bool CheckNumber(int num)
{
    if (num < 99)
    {
        System.Console.WriteLine($"У введенного числа {num} нет третьей цифры");
        return false;
    }
    return true;
}

int num = InputInt("Введите число");

if (CheckNumber(num))
{
    string Numstp1 = num.ToString();
    char Numstp2 = Numstp1[2];
    System.Console.WriteLine($"Третья цифра в введенном числе: {Numstp2}");
}