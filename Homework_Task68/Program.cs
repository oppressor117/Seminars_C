// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
    return n + 1;
    }
    else if (n == 0 && m > 0)
    {
    return Akkerman(m - 1, 1);
    }
    else
    {
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

// Вызов функции Аккермана
void AkkermannFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int numberM = ReadData("Введите число M: ");
int numberN = ReadData("Введите число N: ");
if (numberM < 0 || numberN < 0) //Проверка на ввод неотрицательных чисел
{
    Console.WriteLine("Введите положительные числа M и N!");
    return;
}

AkkermannFunction(numberM, numberN);