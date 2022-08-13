// Принимает на вход пятизначное число и проверяет является ли оно палиндромом 14212 -> нет, 23432 -> да
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length == 5)
    if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
{
        Console.WriteLine("Да");
}
    else
{
        Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Введите неотрицательное пятизначное число");
}