//однострочный коммент

/*Идет обработка действий после создания...
Выполнение "dotnet restore" для C:\Users\Asus\OneDrive\Рабочий стол\C#\C#.csproj...
  Определение проектов для восстановления...
  Восстановлен C:\Users\Asus\OneDrive\Рабочий стол\C#\C#.csproj (за 75 ms).
Восстановление выполнено.*/


// Идет обработка действий после создания...
// Выполнение "dotnet restore" для C:\Users\Asus\OneDrive\Рабочий стол\C#\C#.csproj...
//   Определение проектов для восстановления...
//   Восстановлен C:\Users\Asus\OneDrive\Рабочий стол\C#\C#.csproj (за 75 ms).
// Восстановление выполнено.

// Задача 1: Напишите программу, котороя на вход принимает число и выдаёт его квадрат.(число само на себя умножается)

// Console.WriteLine("Введи число: ");
// int number = int.Parse(Console.ReadLine()!);

// // //Математический способ
// int sqr = number * number;
// // //С библиотекой
// int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine($"Квадрат числа {number} является числом: математический {sqr}, с библиотекой {sqr1}");

// // Задача 2: Напишите программу, которая на вход принимает одно число (N),
// // а на выходе показывает все целые числа в промежутке от -N до N.

// Console.WriteLine("Введи число: ");
// int num = int.Parse(Console.ReadLine()!);
// int num1 = -num;
// while( num1 <= num){
//   Console.Write($"{num1} ");
//   num1++;
// }
/* Задача 3:
 Console.Write("Введи первое число: ");
 int a = int.Parse(Console.ReadLine()!);
 Console.Clear();
 Console.Write("Введи второе число: ");
 int b = int.Parse(Console.ReadLine()!);
 Console.Clear();
 if( a == Convert.ToInt32(Math.Pow(b, 2))){
 Console.Write($"Число {a} является квадратом {b}!");
}
else{
Console.Write($"Число {a} не является квадратом {b}!");
 }*/

/* Задача 4:
Console.Write("Введите номер дня: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1){
  Console.WriteLine("Понедельник");
}
else if( num == 2){
  Console.WriteLine("Вторник");
}
else if( num == 3){
  Console.WriteLine("Среда");
}
else if( num == 4){
  Console.WriteLine("Четверг");
}
else if( num == 5){
  Console.WriteLine("Пятница");
}
else if( num == 6){
  Console.WriteLine("Суббота");
}
else if( num == 7){
  Console.WriteLine("Воскресенье");
}
else {
  Console.WriteLine(" Введите число т 1 до 7 !!!");
}*/

/*Задача 5:
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int result = num % 10;
Console.Write($"Последняя цифра числа {num}: {result}");*/
