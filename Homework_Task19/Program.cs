int num = ReadData ("Введите пятизначное число");

bool result = PalinTest(num);
PrintData(result);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
bool PalinTest(int num)
{
    bool result = false;
    if ((num/10000 == num%10)&&((num/1000)%10 == (num/10)%10)) result = true;
    return result;
}

void PrintData(bool result)
{
    Console.WriteLine(result);
}
