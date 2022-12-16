int N = ReadData ("Введите число N");

string outline = LineBuilder(N, 1);
PrintData("", outline);
outline = LineBuilder(N, 2);
PrintData("", outline);

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

string LineBuilder(int N, int Pow)

{
    string outline = String.Empty;
    for (int i=1; i < N; i++)
    {
        outline = outline + Math.Pow(i, Pow) + " ";
    }
    outline = outline + Math.Pow(N, Pow);
    return outline;
}

void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}

