//Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool ValidNumber(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    System.Console.WriteLine($"Ошибка: Цифра {number} не соотвествует диапазону [1;7]!");
    return false;
}

System.Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if (ValidNumber(number))
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine($"Вы ввели цифру {number} - это выходной день");
    }
    else if (number > 0 || number <= 5)
    {
        System.Console.WriteLine($"Вы ввели цифру {number} - это будний день");
    }
}