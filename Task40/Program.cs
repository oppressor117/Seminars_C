int numA = ReadData ("Введите A");
int numB = ReadData ("Введите B");
int numC = ReadData ("Введите C");

if(TriangleTest(numA, numB, numC)) PrintData("Может существовать треугольник со стронами такой длины.");
else PrintData("Треугольника со сторонами такой длины не существует.");

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

bool TriangleTest(int numA, int numB, int numC)
{
    return((numA+numB>numC)&&(numA+numC>numB)&&(numB+numC>numA));
}
