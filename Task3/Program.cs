#nullable disable

//Программа, которая выдает таблицу кубов от 1 до N
Console.WriteLine("Введите число N"); 
double num = double.Parse(Console.ReadLine());
for(int i=1; i<=num; i++)
{
    Console.WriteLine($"{i*i*i}, ");
}