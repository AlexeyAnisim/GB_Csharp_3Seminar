#nullable disable

// Программа, определяющая расстояние между двумя точками в 3D пространстве
Console.WriteLine("Введите координаты 2-х точек и нажмите Enter");
int numX1 = int.Parse(Console.ReadLine());
int numX2 = int.Parse(Console.ReadLine());
int numY1 = int.Parse(Console.ReadLine());
int numY2 = int.Parse(Console.ReadLine());
int numZ1 = int.Parse(Console.ReadLine());
int numZ2 = int.Parse(Console.ReadLine());

double numX3 = Math.Pow((numX2-numX1),2);
double numY3 = Math.Pow((numY2-numY1),2);
double numZ3 = Math.Pow((numZ2-numZ1),2); 

double distance = Math.Sqrt(numX3+numY3+numZ3);
Console.WriteLine($"расстояние между точками равно {distance}");