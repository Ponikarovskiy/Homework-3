// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.Clear();
// System.Console.WriteLine();
// System.Console.WriteLine("*Задача № 19. Проверка, является ли число палиндромом*");
// System.Console.WriteLine();
// System.Console.WriteLine("Введите пятизначное число число");

// int number = Convert.ToInt32(Console.ReadLine());
// int length = number.ToString().Length;
// int palindrome = 0;
// int num = number;

// if (number < 0)
// {
//     Console.WriteLine("Ввод неверный. Пожалуйста, введите положительное число");
//     return;
// }

// if (length == 5)
// {
//     while (number > 0)
//     {
//         palindrome = palindrome * 10 + number % 10; number /= 10;   
//     }
//     System.Console.WriteLine(num == palindrome ? "да" : "нет");
// }
// else
// {
//     System.Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
// }
// System.Console.WriteLine();


// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("*Задача № 21. Поиск расстояние между двумя точками в 3D пространстве*");
System.Console.WriteLine();

int x1 = Coordinate("-x-", "A");
int y1 = Coordinate("-y-", "A");
int z1 = Coordinate("-z-", "A");
int x2 = Coordinate("-x-", "B");
int y2 = Coordinate("-y-", "B");
int z2 = Coordinate("-z-", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double result (double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double SegmentLength =  Math.Round (result(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {SegmentLength}");

// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

