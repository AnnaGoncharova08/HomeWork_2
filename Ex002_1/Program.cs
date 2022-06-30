// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Random rand = new Random();
int number = rand.Next(1,8);
Zadacha9(number);

void Zadacha9(int currentnumber)
{
    Console.WriteLine(currentnumber);
    if (currentnumber == 1)
        Console.WriteLine("Сегодня понедельник - рабочий день");
    if (currentnumber == 2)
        Console.WriteLine("Сегодня вторник - рабочий день");
    if (currentnumber == 3)
        Console.WriteLine("Сегодня среда - рабочий день");
    if (currentnumber == 4)
    Console.WriteLine("Сегодня четверг - рабочий день");
    if (currentnumber == 5)
    Console.WriteLine("Сегодня пятница - рабочий день");
    if (currentnumber == 6)
    Console.WriteLine("Сегодня суббота - выходной день");
    if (currentnumber == 7)
    Console.WriteLine("Сегодня воскресенье - выходной день");
}