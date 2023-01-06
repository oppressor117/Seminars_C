int inputNumber = ReadData ("Введите N чисел: ");
PrintData("Кол-во положительных чисел: ", CountPosNum(inputNumber));

int ReadData(string msg) //Ввод чисел пользователем
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

void PrintData(string msg, int res) //Вывод результата
{
    Console.WriteLine(msg+res);
}

int CountPosNum(int N) //Подсчет кол-ва положительных чисел
{
    int res = 0;
    while(N > 0)
    {
        if(ReadData("Введите число: ")>0) res++;
        N = N - 1;
    }
    return res;

}