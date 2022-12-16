int num = ReadData ("Введите число: ");

int res = VariantSimple(num);
DateTime d1 = DateTime.Now;
int res1 = VariantSimple(num);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VariantString(num);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
int res3 = VariantLog(num);
Console.WriteLine(DateTime.Now - d3);

PrintResult("Количество цифр в числe: " + res1);
PrintResult("Количество цифр в числe: " + res2);
PrintResult("Количество цифр в числe: " + res3);

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine()??"0");
}

int VariantSimple(int num) // res = num.ToString().Length; // res = int MathLog10(num)+1;
{
    int res = 0;
    while(num > 0)
    {
        res++;
        num = num / 10;
    }
    return res;
}

int VariantString(int num)
{
    int res = num.ToString().Length;
    return res;
}

int VariantLog(int num)
{
    int res = (int)Math.Log10(num)+1;
    return res;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}