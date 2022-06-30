// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
Zadacha13(number);

void Zadacha13(string currentnumber)
{
        if (currentnumber.Length >= 3)
        {
            Console.WriteLine($"Третья цифра равна {currentnumber[2]}");
        }
        else
        {
            Console.WriteLine($"Третьей цифры нет");
        }
}