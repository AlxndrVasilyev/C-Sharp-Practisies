// Найти расстояние между точками в пространстве 2D/3D

// AB = √((xb - xa)ˆ2 + (yb - ya)ˆ2)
// AB = √((xb - xa)ˆ2 + (yb - ya)ˆ2 + (zb - za)ˆ2)

int x1 = new Random().Next(-99, 99);
int x2 = new Random().Next(-99, 99);
int y1 = new Random().Next(-99, 99);
int y2 = new Random().Next(-99, 99);
int z1 = new Random().Next(-99, 99);
int z2 = new Random().Next(-99, 99);

Console.WriteLine($"x1 = {x1}, x2 = {x2}, y1 = {y1}, y2 = {y2}, z1 = {z1}, z2 = {z2}");

int distance2D = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));
int result2d = Convert.ToInt32(Math.Sqrt(distance2D));

int distance3D = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1));
int result3d = Convert.ToInt32(Math.Sqrt(distance3D));

Console.WriteLine($"distance2D = {result2d}");
Console.WriteLine($"distance3D = {result3d}");