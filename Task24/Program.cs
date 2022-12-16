int numA = ReadData ("Введите число A: ");

DateTime d1 = DateTime.Now;
int res1 = VariantSumSimple(numA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantSumGause(numA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна (простой метод):" + res1);
PrintResult("Сумма чисел от 1 до А равна (метод Гауса):" + res2);

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA)

{
    int sumOfNumbers = 0;
    for(int i = 1; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;

}

int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}