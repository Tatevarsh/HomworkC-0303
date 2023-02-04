// Задача 21

// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x1,y1,z1 :");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите x2,y2,z2 :");
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);



double dx = Math.Pow(x1-x2,2);
double dy = Math.Pow(y1-y2,2);
double dz = Math.Pow(z1-z2,2);

double n = Math.Sqrt(dx+dy+dz);

n = Math.Round(n,2);

Console.WriteLine($"расстояние:{n}");


