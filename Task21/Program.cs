// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату точки А по оси Х:");
double ax = double.Parse (Console.ReadLine ());
Console.WriteLine("Введите координату точки А по оси Y:");
double ay = double.Parse (Console.ReadLine ());
Console.WriteLine("Введите координату точки А по оси Z:");
double az = double.Parse (Console.ReadLine ());

Console.WriteLine("Введите координату точки B по оси Х:");
double bx = double.Parse (Console.ReadLine ());
Console.WriteLine("Введите координату точки B по оси Y:");
double by = double.Parse (Console.ReadLine ());
Console.WriteLine("Введите координату точки B по оси Z:");
double bz = double.Parse (Console.ReadLine ());


double dist = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2)+ Math.Pow((az - bz), 2));

Console.WriteLine (Math.Round(dist, 2));
