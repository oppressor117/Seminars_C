// Задача 67
// Принимает на вход число и возвращает сумму цифр в числе

int numberN = ReadData("Введите число N: ");
int sum = RecSumDig(numberN);
PrintResult(sum);

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(int prefix)
{
    Console.Write(prefix);
}

int RecSumDig(int n)
{
    if (n<= 10) return n;
    int result = n % 10 + RecSumDig(n/10);
    return result;
}

