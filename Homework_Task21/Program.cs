int x1 = ReadData ("Введите координату x1");
int y1 = ReadData ("Введите координату y1");
int z1 = ReadData ("Введите координату z1");
int x2 = ReadData ("Введите координату x2");
int y2 = ReadData ("Введите координату y2");
int z2 = ReadData ("Введите координату z2");

double res = CalculateLength(x1, y1, z1, x2, y2, z2);
PrintData("Расстояние между двумя точками в пространстве равно ", res);
// PrintData("Расстояние между точками: ", res), CalculateLength(x1, y1, z1, x2, y2, z2);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

double CalculateLength(int x1, int y1, int z1, int x2, int y2, int z2)

{
    double res = 0;
    res = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1)); //Math.Pow((x1-x2),2)
    return res;
}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

