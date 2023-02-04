// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

int remineder, sum = 0;
int temp = number;
while (number > 0)

{

    remineder = number % 10;
    sum = (sum * 10) + remineder;
    number = number / 10; 

}
if (temp == sum)

{
    Console.WriteLine($"Number {temp} палидром.");
}
    else

{
    Console.WriteLine($"Number {temp} нет");
}
            Console.ReadKey();












