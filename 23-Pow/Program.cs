/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
*/

void ShowPowFromNumbers(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.Write(Math.Pow(current, 3));
        if (current < number) Console.Write(", ");
        else Console.WriteLine();
        current++;
    }
}

bool IsCorrectInput(int number)
{
    return number > 0;
}

int number;

Console.WriteLine("Отображение кубов чисел от 1 до N");
Console.Write("Введите число: ");

while (!IsCorrectInput(number = Convert.ToInt32(Console.ReadLine())))
{
    Console.Write("Вы ввели неправильное число! Повторите ввод: ");
}

ShowPowFromNumbers(number);