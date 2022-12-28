//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
  
// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num/10000%10;
// int b = num%10;
// int c = num/1000%10;
// int d = num/10%10;
// int e = num/100%10;

// while((num>100000) && (num<100000)); 
// if(a==b && c==d) 
//   {
//   Console.WriteLine($"{a}{c}{e}{d}{b} - палиндромом ");
//   }  
// else 
//   {
//   Console.WriteLine($"{a}{c}{e}{d}{b} - не палиндромом ");
//   }

// КАК ТУТ ЗАЦИКЛИТЬ ЧТОБЫ В ТЕРМИНАЛЕ НЕ ПРИХОДИЛОСЬ ПОСТОЯННО ЗАПУСКААТЬ ПРОГРАММУ, А ПРОСТО ВВОДИТЬ ПЯТИЗНАЧНОЕ ОДИН ЗА ДРУГИМ?




    

//Задача 21 
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите значение X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double z = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));  

// Console.WriteLine($"d={z:f3}");

//ГДЕ МОЖНО НАЙТИ ИНФ О ТОМ КАКИЕ ФУНКЦИИ БЫВАЮТ В C#?







    
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.    

Console.WriteLine("Введите значение X: ");
int X = int.Parse(Console.ReadLine());

for(int i=1; i<=X; i++)
{
  Console.WriteLine($" {i*i*i}");
}

