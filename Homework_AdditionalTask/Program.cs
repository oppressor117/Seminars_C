string str = ReadData ("Введите имена через запятую: ");

PrintResult(" " + NameChoice(str));

string ReadData(string line)
{
    Console.WriteLine(line);
    return Console.ReadLine()??"0";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

string NameChoice(string str)
{
    string[] names = str.Split(",");
    string name = names[new Random().Next(0, names.Length)].Trim();
    return name;
}