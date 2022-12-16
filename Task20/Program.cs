int x1 = ReadData ("Введите координату x1");
int y1 = ReadData ("Введите координату y1");
int x2 = ReadData ("Введите координату x2");
int y2 = ReadData ("Введите координату x2");

double res = CalculateLength(x1, y1, x2, y2);
PrintData("Расстояние между точками: ", res);
// PrintData("Расстояние между точками: ", res), CalculateLength(x1, y1, x2, y2);;

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

double CalculateLength(int x1, int y1, int x2, int y2)

{
    double res = 0;
    res = Math.Sqrt((x1 - x2)*(x1 - x2)+(y1 - y2)*(y1-y2)); //Math.Pow((x1-x2),2)
    return res;
}

void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

