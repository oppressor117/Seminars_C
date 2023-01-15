// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int result)
{
    Console.WriteLine(result);
}

//Нахождение суммы через рекурсию
int SumRecMN(int M, int N)
{
    if (M >= N) return N;
    return M + SumRecMN(M + 1, N);
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
//int result = SumRecMN(number1, number2);
int result = number1<number2? SumRecMN(number1, number2):SumRecMN(number2, number1);
PrintResult(result);