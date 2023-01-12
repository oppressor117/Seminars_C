int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение массива
int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(-99, 100);
        }
    }
    return array2D;
}

int SearchElem(int[,] matrix, int x, int y)
{   
    int elem = -1;
    if(x<matrix.GetLength(0))
        if(y<matrix.GetLength(1))
    {
        elem = matrix[x, y];
    }
        return elem;
}

void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

void PrintData(int result)
{
    Console.WriteLine(result);
}

int[,] arr2D = Fill2DArray(5, 5); //Генерируем массив, задаем кол-во строк и столбцов
int row = ReadData("Введите номер строки "); //Пользователь вводит значение
int column = ReadData("Введите номер столбца "); //Пользователь вводит значение
Print2DArrayColor(arr2D); //Выводится сгенерированный массив
if(row<5&&column<5) PrintData(SearchElem(arr2D, row, column));
else Console.WriteLine("Такого числа в массиве нет!");