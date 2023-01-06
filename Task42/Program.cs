int inputNumber = ReadData ("Введите число: ");
PrintData(DecToBin(inputNumber));
PrintData(DecToBinNative(inputNumber));
PrintData(Convert.ToString(inputNumber, 8));
PrintData(Convert.ToString(inputNumber, 16));

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string res)
{
    Console.WriteLine(res);
}

string DecToBin(int num) // Преобразование десятичного в двоичную
{
    string outBin = string.Empty;
    while(num>0)
    {
        outBin = (num%2) + outBin;
        num = num/2;
    }
    return outBin;
}

string DecToBinNative(int num)
{
    return Convert.ToString(num, 2);
}