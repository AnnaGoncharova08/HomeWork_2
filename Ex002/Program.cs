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
    if (currentnumber == 6 || currentnumber == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}