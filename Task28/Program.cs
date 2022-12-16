using System.Numerics;

int num = ReadData ("Введите число: ");

BigInteger res = CalcFact(num);
PrintResult("Факториал: " + res);

int ReadData(string res)
{
    Console.WriteLine(res);
    return int.Parse(Console.ReadLine()??"0");
}
BigInteger CalcFact(int num)
{
    BigInteger res = 1;
    for(int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}

void PrintResult(string res)
{
    Console.WriteLine(res);
}