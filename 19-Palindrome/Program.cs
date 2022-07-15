/*
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом
*/

bool IsPolindrome(int number)
{
    return number / 1000 == number / 10 % 10 + number % 10 * 10;
}

bool IsCorrectInput(int number)
{
    return(number >= 10000 && number <= 99999);
}

string GetTextResult(int number)
{
    string text = $"Число {number} ";
    if (!IsPolindrome(number)) text+= "НЕ ";
    return text += "является палиндромом.";
}

int number;

Console.WriteLine("Является ли число палиндромом?");
Console.Write("Введите пятизначное число: ");

while (!IsCorrectInput(number = Convert.ToInt32(Console.ReadLine())))
{
    Console.Write("Вы ввели неправильное число! Повторите ввод: ");
}

Console.WriteLine(GetTextResult(number));