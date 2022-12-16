int num = ReadData ("Введите число: ");

int res = SumDigit(num);

PrintResult("Сумма цифр в числe: " + res);

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int SumDigit(int num)
{
    int res = 0;
    while(num > 0)
    {
    res += num%10;
    num = num/10;
    }
    return res;
}

