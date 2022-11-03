#nullable disable

// Программа проверки пятизначного числа на палиндром
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

int number1 = number.Length;

if(number1 == 5)
{
    if(number[0] == number[4]  && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
      Console.WriteLine($"{number} - Не палиндром");  
    }
} 
else
{
    Console.WriteLine($"Число: {number} - не пятизначное число");
}