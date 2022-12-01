// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distance}");
}

int x1 = DataEntryXY("Введите X1 = ");
int y1 = DataEntryXY("Введите Y1 = ");
int z1 = DataEntryXY("Введите Z1 = ");
int x2 = DataEntryXY("Введите X2 = ");
int y2 = DataEntryXY("Введите Y2 = ");
int z2 = DataEntryXY("Введите Z2 = ");

PrintDistance(x1, x2, y1, y2, z1, z2);