// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Понедельник - не выходной"); 
}
else if (number == 2)
{
    Console.WriteLine("Вторник - не выходной"); 
}
else if (number == 3)
{
    Console.WriteLine("Среда - не выходной");  
}
else if (number == 4)
{
    Console.WriteLine("Четверг - не выходной"); 
}
else if (number == 5)
{
    Console.WriteLine("Пятница - не выходной"); 
}
else if (number == 6)
{
    Console.WriteLine("Суббота - ура, выходной!"); 
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье - ура, выходной!");  
}
