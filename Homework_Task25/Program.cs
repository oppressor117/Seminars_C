int numA = ReadData ("Введите число A: ");
int numB = ReadData ("Введите число B: ");

int res = Pow(numA, numB);
PrintData(numA+" в натуральной степени "+numB+" равно "+res);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

int Pow(int numA, int numB)
{
    int res = 1;
    for(int i = 1; i <= numB; i++)
    {
        res = numA * res;
    }
    return res;
}

void PrintData(string line)
{
    Console.WriteLine(line);
}